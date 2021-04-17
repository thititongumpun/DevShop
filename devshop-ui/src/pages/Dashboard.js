import {
  StyledTitle,
  StyledSubTitle,
  Avatar,
  StyledButton,
  ButtonGroup,
  StyledFormArea,
  colors
} from "./../components/Styles";
import Logo from '../assets/dev.png'

export const Dashboard = () => {
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
        <Avatar image={Logo}/>
      </div>
      <StyledFormArea bg={colors.dark2}>
        <StyledTitle size={65}>Welcome Folk!</StyledTitle>
        <StyledSubTitle size={27}>Get Ready</StyledSubTitle>

        <ButtonGroup>
          <StyledButton to="#">Logout</StyledButton>
        </ButtonGroup>
      </StyledFormArea>
    </div>
  );
}