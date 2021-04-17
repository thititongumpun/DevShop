import axios from 'axios';

const API_URL = 'http://localhost:5000/api/auth';

const register = (username, email, password) => {
  return axios.post(API_URL + 'register', {
    username,
    email,
    password,
  });
};

const login = (username, password) => {
  return axios
    .post(API_URL + 'login', {
      username,
      password
    })
    .then((response) => {
      const { data } = response;
      if (data.Token) {
        localStorage.setItem('user', JSON.stringify(data));
      }
      return data;
    });
};

const logout = () => {
  localStorage.removeItem('user');
};

// eslint-disable-next-line import/no-anonymous-default-export
export default {
  register,
  login,
  logout
};