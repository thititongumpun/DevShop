// import {
//   REGISTER_SUCCESS,
//   REGISTER_FAIL,
//   LOGIN_SUCCESS,
//   LOGIN_FAIL,
//   LOGOUT
// } from './types';

// import AuthService from '../services/auth.services';
import axios from 'axios';

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
            console.log('token later');
            //Token here later !!
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
            setFieldError('username', data.Errors);
          } else if (data.Errors) {

          }
          setSubmitting(false);
        } else if (data.Success === true) {
          const { username, email, password } = user;

          dispatch({ username, email, password, history, setFieldError, setSubmitting });
        }
      })
      .catch((err) => console.error(err));
  }
};