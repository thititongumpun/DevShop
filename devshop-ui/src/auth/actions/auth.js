import axios from 'axios';
import {
  REGISTER_SUCCESS,
  REGISTER_FAIL,
  LOGIN_SUCCESS,
  LOGIN_FAIL,
  LOGOUT,
  SET_MESSAGE
} from './types';

const API_URL = 'http://localhost:5000/api/auth/';

const headers = {
  "Content-Type": "application/json"
}

export const loginUser = (user, history, setFieldError, setSubmitting) => {
  return (dispatch) => {
    axios
      .post(API_URL + 'login', user, headers)
        .then((response) => {
          const { data } = response;
          console.log(data);
          if (data.Success === false) {
            if (data.Errors) {
              dispatch({
                type: LOGIN_FAIL,
              });
              setFieldError('password', data.Errors);
              console.error(data.Errors);
            }
          } else if (data.Success === true) {
              dispatch({
              type: LOGIN_SUCCESS,
              payload: { user: data },
            });
            localStorage.clear();
            localStorage.setItem('user', JSON.stringify(data));
            history.push("/dashboard");
          }
          setSubmitting(false);
        })
        .catch((err) => {
          const { message } = err;
          dispatch({
            type: SET_MESSAGE,
            payload: message
          })
        });
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

              dispatch({
                type: REGISTER_FAIL
              })

              console.log(data.Errors);
              setFieldError('username', data.Errors);
            } else if (data.Errors) {
              setFieldError('email', data.Errors);
            }
            setSubmitting(false);
          } else if (data.Success === true) {

            dispatch({
              type: REGISTER_SUCCESS,
              payload: {user: data},
            })

            const { username, password } = user;

            dispatch(
              loginUser({ username, password }, history, setFieldError, setSubmitting)
            );
          }
        })
        .catch((err) => {
          const { message } = err;
          dispatch({
            type: SET_MESSAGE,
            payload: message
          })
        });
      }
    };

export const logoutUser = (history) => {
  return (dispatch) => {
    localStorage.removeItem('user');
    history.push('/');

    dispatch({
      type: LOGOUT,
    });
  }
};

