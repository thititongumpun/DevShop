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

export const loginUser = (user, history, setFieldError, setSubmitting) => {
  return () => {
    axios
      .post(API_URL + 'login', user)
      .then((response) => {
        const { data } = response;
        console.log(data);
        if (data.Success === false) {
          if (data.Errors) {
            setFieldError('password', data.Errors);
          }
        } else if (data.Success === true) {
          console.log('token later');
          //Token here later !!
        }
        setSubmitting(false);
      })
      .catch((err) => console.error(err));
  }
};