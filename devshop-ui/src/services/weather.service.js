import axios from 'axios';
// import authHeader from '../helpers/auth.header';

// function authHeader() {
//   let user = JSON.parse(localStorage.getItem('user'));

//   if (user && user.Token) {
//     return {
//         'Authorization':
//         'Bearer' + user.Token
//       };
//     } else {
//       return {};
//     }
// };

const API_URL = process.env.REACT_APP_DATA_URL;

const authStr = 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3VwZXJhZG1pbiIsImp0aSI6IjBiMmM0ZDY3LWY4Y2UtNDJjYy1hZWRjLTlhZWQwNThhOTg5YiIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluIiwiZXhwIjoxNjE4ODYwMjMwfQ.IwtAafhxQ-aSAfIGQKtvqoooE3w3YJ0SXnLWeqIdRZI';

const getWeather = () => {
  return axios.get(API_URL, { headers: {'Authorization': authStr}});
};

const getTest = () => {
  return axios.get('https://jsonplaceholder.typicode.com/todos?_limit=5s');
};

export default { getWeather, getTest };

