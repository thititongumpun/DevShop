import { Route, Redirect } from 'react-router-dom';
import { connect } from 'react-redux';

const BasicRoute = ({ children, isLoggedIn, ...rest }) => {
  return (
    <Route
      {...rest}
      render={
        ({ location }) =>
          !isLoggedIn ? (children) : (
          <Redirect
            to={{
              pathname: "/dashboard",
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

export default connect(mapStateToProps)(BasicRoute);