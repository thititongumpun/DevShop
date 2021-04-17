import React from 'react'
import { Formik, Form } from 'formik';
import { TextInput } from '../components/FormLib';
import { FiUsers, FiLock } from 'react-icons/fi'
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


export const Login = () => {
  return (
    <div>
      <StyledFormArea>
        <StyledTitle color={colors.theme} size={30}>
          Login
        </StyledTitle>
        <Formik
          initialValues={{
            username: '',
            password: ''
          }}
          validationSchema={Yup.object({
            username: Yup.string()
              .min(5, 'Username is too long')
              .max(30, 'Username is too long')
              .required('Username Is Required'),
            password: Yup.string()
              .min(5, 'Password is too short')
              .max(15, 'Password is too long')
              .required('Password Is Required'),
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
                name="password"
                type="password"
                label="Password"
                placeholder="*****"
                icon={<FiLock />}
              />
              <ButtonGroup>
                {!isSubmitting && (
                <StyledFormButton type="submit">
                  Login
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
            <TextLink to="/signup">Sign Up</TextLink>
        </ExtraText>
        <CopyrightText>
        &copy;
      </CopyrightText>
      </StyledFormArea>
    </div>
  )
}
