import { Route, Redirect } from 'react-router-dom';
import { connect } from 'react-redux';

const AuthRoute = ({ children, isLoggedIn, ...rest }) => {
  return (
    <Route
      {...rest}
      render={
        ({location}) => isLoggedIn ? (children) : (
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

const mapStateToProps = ({ authentication }) => ({
  isLoggedIn: authentication.isLoggedIn
});

export default connect(mapStateToProps)(AuthRoute);

// export default AuthRoute;