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
        <StyledTitle size={65}>Welcome Folk!</StyledTitle>
        <StyledSubTitle size={27}>Get Ready</StyledSubTitle>
        <ButtonGroup>
          <StyledButton to="#" onClick={() => logoutUser(history)}>Logout</StyledButton>
        </ButtonGroup>
      </StyledFormArea>
    </div>
  );
};

export default connect(null, { logoutUser })(Dashboard);
// const mapStateToProps = ({})