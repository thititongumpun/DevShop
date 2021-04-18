import { Route, Redirect } from 'react-router-dom';
import { connect } from 'redux';

const AuthRoute = ({ children, authenticated, ...rest }) => {
  return (
    <Route
      {...rest}
      render={
        ({location}) => authenticated ? (children) : (
          <Redirect
            to={{
              pathname: "/login",
              state: {from: location}
            }}
          />
        )
      }
    />
  );
};

const mapStateToProps = ({ user }) => ({
});

export default connect()(AuthRoute);