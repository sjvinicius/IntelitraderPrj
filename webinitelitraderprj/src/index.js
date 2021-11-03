//Libs
import React from 'react';
import ReactDOM from 'react-dom';
import {Switch, Route, BrowserRouter} from 'react-router-dom'

//Services
import reportWebVitals from './reportWebVitals';

//Styles
import Login from './pages/Login'
import CandidatoListar from './pages/CandidatoListar'
import Modal from './pages/CandidatoListar'
import './index.css';

const route =(

  <>
    <BrowserRouter initialRouteName='Login'>
      <Switch>
        <Route exact path='/' name='Raiz' component={Login} />
        <Route path='/Login' name='Login' component={Login} />
        <Route path='/Listar' name='Candidato' component={CandidatoListar} />
        
        {/* <Route path='/ListarRH' name='RH' component={RHListar} /> */}
        {/* <Route/> */}
        {/* <Route/> */}
      </Switch>
    </BrowserRouter>
  </>

)

ReactDOM.render(
  route,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
