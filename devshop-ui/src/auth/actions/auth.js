import axios from 'axios';
// import { REGISTER_SUCCESS } from './types';

const API_URL = 'http://localhost:5000/api/auth/';

const headers = {
  "Content-Type": "application/json"
}

export const loginUser = (user, history, setFieldError, setSubmitting) => {
  return () => {
    axios
      .post(API_URL + 'login', user, headers)
        .then((response) => {
          const { data } = response;
          console.log(data);
          if (data.Success === false) {
            if (data.Errors) {
              setFieldError('password', data.Errors);
              console.error(data.Errors[0]);
            }
          } else if (data.Success === true) {
            localStorage.clear();
            localStorage.setItem('user', JSON.stringify(data));
            history.push("/dashboard");
          }
          setSubmitting(false);
        })
        .catch((err) => console.error(err));
      }
    };

export const registerUser = (user, history, setFieldError, setSubmitting) => {
  return (dispatch) => {
    axios
      .post(API_URL + 'register', user, headers)
        .then((response) => {
          const { data } = response;
          console.log(data);
          if (data.Success === false) {
            if (data.Errors) {
              console.log(data.Errors);
              setFieldError('username', data.Errors);
            } else if (data.Errors) {
              setFieldError('email', data.Errors);
            }
            setSubmitting(false);
          } else if (data.Success === true) {
            const { username, password } = user;

            dispatch(
              // { type: REGISTER_SUCCESS },
              loginUser({ username, password }, history, setFieldError, setSubmitting)
            );
          }
        })
        .catch((err) => console.error(err));
      }
    };

export const logoutUser = (history) => {
  return () => {
    localStorage.removeItem('user');
    history.push('/login');
  }
};

