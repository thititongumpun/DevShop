import { StyledContainer } from './components/Styles';
import { Home } from './pages/Home';
import Login from './pages/Login';
import Signup from './pages/Signup';
import Dashboard from './pages/Dashboard';

import "react-loader-spinner/dist/loader/css/react-spinner-loader.css";

import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import BasicRoute from './components/BasicRoute';
import AuthRoute from './components/AuthRoute';
import { connect } from 'react-redux';

function App({isLoggedIn}) {
  return (
    <Router>
      {isLoggedIn && (
      <StyledContainer>
        <Switch>
          <BasicRoute path="/signup">
            <Signup />
          </BasicRoute>
          <BasicRoute path="/login">
            <Login />
          </BasicRoute>
          <AuthRoute path="/dashboard">
            <Dashboard />
          </AuthRoute>
          <Route path="/">
            <Home />
          </Route>
        </Switch>
      </StyledContainer>
      )}
    </Router>
  );
}

const mapStateToProps = ({ authentication }) => ({
  isLoggedIn : authentication
});

export default connect(mapStateToProps)(App);
