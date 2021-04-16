import React from 'react'
import { Formik, Form } from 'formik';
import { TextInput } from '../components/FormLib';
import {FiUsers, FiLock} from 'react-icons/fi'
import {
  StyledTextInput,
  StyledFormArea,
  StyledFormButton,
  StyledLabel,
  StyledTitle,
  colors,
  ButtonGroup
} from '../components/Styles';


export const Login = () => {
  return (
    <div>
      <StyledFormArea>
        <StyledTitle color={colors.theme} size={30}>
          Login
        </StyledTitle>
        <Formik>
          {() => (
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
                <StyledFormButton type="submit" disabled={true}>
                  Login
                </StyledFormButton>
              </ButtonGroup>
            </Form>
          )}
        </Formik>
      </StyledFormArea>
    </div>
  )
}
