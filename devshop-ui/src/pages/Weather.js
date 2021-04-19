import React, { useState, useEffect } from 'react';
import WeatherService from '../services/weather.service';
import {
  StyledContainer,
  StyledTitle,
  StyledSubTitle,
  Avatar,
  StyledButton,
  ButtonGroup,
  StyledFormArea,
  colors,
  StyledLabel
} from "./../components/Styles";


import { connect } from 'react-redux';


const Weather = ({user}) => {
  const [weathers, setData] = useState([]);
  useEffect(() => {
    // WeatherService.getWeather().then((response) => {
    //   const { data } = response;
    //   setData(data);
    //   console.log(response);

      WeatherService.getTest().then((response) => {
        const { data } = response;
        setData(data);
        console.log(data);
    },
      (error) => {
        const { message } = error;
        setData(message);
        console.log(message);
      });
  }, []);

  return (
    <StyledFormArea color={colors.light1}>
      <StyledTitle size={25} color={colors.dark1}>Weatherforecast!!!</StyledTitle>
      <div>{weathers.map(weather =>
        <div key={weather.id}>
          <br />
          <StyledLabel>Date: {weather.id}</StyledLabel>
          <StyledLabel>Temp C: {weather.title}</StyledLabel>
          <StyledLabel>Temp F: {weather.completed}</StyledLabel>
          {/* <StyledLabel>Summary: {weather.Summary}</StyledLabel> */}
        </div>
      )}
      </div>

    </StyledFormArea>
  );
};


const mapStateToProps = ({ authentication }) => ({
  user: authentication.user
});

export default connect(mapStateToProps)(Weather);
// export default Weather;
