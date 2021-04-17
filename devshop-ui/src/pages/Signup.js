import React from 'react'
import { Formik, Form } from 'formik';
import { TextInput } from '../components/FormLib';
import { FiUsers, FiLock, FiMail } from 'react-icons/fi'
import * as Yup from 'yup';
import Loader from 'react-loader-spinner';
import {
  StyledFormArea,
  StyledFormButton,
  StyledTitle,
  colors,
  ButtonGroup,
  ExtraText,
  TextLink,
  CopyrightText
} from '../components/Styles';


export const Signup = () => {
  return (
    <div>
      <StyledFormArea>
        <StyledTitle color={colors.theme} size={30}>
          Sign Up
        </StyledTitle>
        <Formik
          initialValues={{
            username: '',
            email: '',
            password: '',
            repeatPassword: ''
          }}
          validationSchema={Yup.object({
            username: Yup.string()
              .min(5, 'Username is too long')
              .max(30, 'Username is too long')
              .required('Username Is Required'),
            email: Yup.string()
              .email('Invalid Email')
              .required('Email Is Required'),
            password: Yup.string()
              .min(5, 'Password is too short')
              .max(15, 'Password is too long')
              .required('Password Is Required'),
            repeatPassword: Yup.string()
              .required('Repeat Password Is Required')
              .oneOf([Yup.ref('password')], 'Password must match')
          })}
          onSubmit={(values, { setSubmitting }) => {
            console.log(values);
          }}
        >
          {({ isSubmitting  }) => (
            <Form>
              <TextInput
                name="username"
                type="text"
                label="Username"
                placeholder="username"
                icon={<FiUsers />}
              />
              <TextInput
                name="email"
                type="text"
                label="Email"
                placeholder="example@google.com"
                icon={<FiMail />}
              />
              <TextInput
                name="password"
                type="password"
                label="Password"
                placeholder="*****"
                icon={<FiLock />}
              />
              <TextInput
                name="repeatPassword"
                type="password"
                label="Repeat Password"
                placeholder="*****"
                icon={<FiLock />}
              />
              <ButtonGroup>
                {!isSubmitting && (
                <StyledFormButton type="submit">
                  Signup
                </StyledFormButton>
                )}
                {isSubmitting  && (
                  <Loader
                    type="Bars"
                    color={colors.theme}
                    height={40}
                    width={100}
                  />
                )}
              </ButtonGroup>
            </Form>
          )}
        </Formik>
        <ExtraText>
            Already Have an Account ? <TextLink to="/login">Login</TextLink>
        </ExtraText>
        <CopyrightText>
        &copy;
      </CopyrightText>
      </StyledFormArea>
    </div>
  )
}
