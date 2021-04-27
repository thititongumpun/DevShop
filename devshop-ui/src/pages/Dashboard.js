import {
  StyledTitle,
  StyledSubTitle,
  Avatar,
  StyledButton,
  ButtonGroup,
  StyledFormArea,
  colors
} from "./../components/Styles";

import { connect } from 'react-redux';
import { logoutUser } from '../auth/actions/auth';
import {useHistory} from 'react-router-dom'
import Logo from '../assets/dev.png'

const Dashboard = ({logoutUser, user}) => {
  const history = useHistory();
  return (
    <div>
      <div
        style={{
          position: "absolute",
          top: 0,
          left: 0,
          backgroundColor: "transparent",
          width: "100%",
          padding: "15px",
          display: "flex",
          justifyContent: "flex-start",
        }}
      >
        <Avatar image={Logo} />
      </div>
      <StyledFormArea bg={colors.dark2}>
        <StyledTitle size={65}>Welcome {user.Username} !</StyledTitle>
        <StyledSubTitle size={27}>Roles {user.Roles}</StyledSubTitle>
        <ButtonGroup>
          <StyledButton to="#" onClick={() => logoutUser(history)}>Logout</StyledButton>
          <StyledButton to="/weather">WeatherForeCast</StyledButton>
          <StyledButton to="/todo">Todo</StyledButton>
          <StyledButton to="/Exchange">Exchange Rate</StyledButton>
        </ButtonGroup>
      </StyledFormArea>
    </div>
  );
};

const mapStateToProps = ({ authentication }) => ({
  user: authentication.user
});

export default connect(mapStateToProps, { logoutUser })(Dashboard);