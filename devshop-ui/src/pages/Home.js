import { StyledSubTitle, StyledTitle, Avatar, StyledButton, ButtonGroup } from '../components/Styles';

import Logo from '../assets/dev.png';

export const Home = () => {
  return (
    <div>
      <div
        style={{
        position: 'absolute',
        top: 0,
        left: 0,
        backgroundColor: 'transparent',
        width: '100%',
        padding: '15px',
        display: 'flex',
        justifyContent: 'flex-start'
      }}>
      <Avatar image={Logo} />
      </div>
      <StyledTitle size={65}>
        Home Page
      </StyledTitle>
      <StyledSubTitle size={27}>
        Home Page Subtitle
      </StyledSubTitle>

      <ButtonGroup>
        <StyledButton to="/login">Login</StyledButton>
        <StyledButton to="/signup">Signup</StyledButton>
      </ButtonGroup>
    </div>
  );
}

