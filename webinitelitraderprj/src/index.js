//Libs
import React from 'react';
import ReactDOM from 'react-dom';
import {Switch, Route, BrowserRouter, Redirect} from 'react-router-dom'

//Services
import reportWebVitals from './reportWebVitals';

//Styles
import Login from './pages/Login'
import CandidatoListar from './pages/CandidatoListar'
import CandidatoListarMinhas from './pages/CandidatoListarMinhas'
import RHListar from './pages/RHListar'
import LiderListar from './pages/LiderListar'
import './index.css';

const PermCand = () => {
  
  var varteste = '1';

  return(

    // UserAuth() === true &&
    // ParseJwt.role 
    varteste === '1' ?
    <Route path='/Listar' name='Candidato' component={CandidatoListar} />
    :
    <Redirect to = '/login' />
    
  )
}
// const PermRH = () => {
  
//   var varteste = '2';

//   return(

//     // UserAuth() === true &&
//     // ParseJwt.role 
//     varteste === '2' ?
//     <Route path='/Listar' name='Candidato' component={CandidatoListar} />
//     :
//     <Redirect to = '/login' />
    
//   )
// }
// const PermLíder = () => {
  
//   var varteste = '3';

//   return(

//     // UserAuth() === true &&
//     // ParseJwt.role 
//     varteste === '1' ?
//     <Route path='/Listar' name='Candidato' component={CandidatoListar} />
//     :
//     <Redirect to = '/login' />
    
//   )
// }

const route =(

  <>
    <BrowserRouter initialRouteName='Login'>
      <Switch>
        <Route exact path='/' name='Raiz' component={Login} />
        <Route path='/Login' name='Login' component={Login} />
        
        <PermCand path='/Listar' name='Candidato' component={CandidatoListar} />
        <Route path='/ListarMinhas' name='CandidatoMinhas' component={CandidatoListarMinhas} />
        
        <Route path='/ListarRH' name='RH' component={RHListar} />
        <Route path='/ListarLider' name='Lider' component={LiderListar} />
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
