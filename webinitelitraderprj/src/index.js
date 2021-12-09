//Libs
import React from 'react';
import ReactDOM from 'react-dom';
import { Switch, Route, BrowserRouter, Redirect } from 'react-router-dom'

//Services
import reportWebVitals from './reportWebVitals';

//Components
import Login from './pages/Login'

import Cadastrar from './pages/Cadastrar'

import CandidatoListar from './pages/CandidatoListar'
import CandidatoListarMinhas from './pages/CandidatoListarMinhas'
import CandidatoListarCandidaturas from './pages/CandidatoListarCandidaturas';

import RHListar from './pages/RHListar'
import CandidatosRH from './pages/RHSelecionados'

import LiderListar from './pages/LiderListar'
import LiderSelecionados from './pages/LiderSelecionados';

//Styles
import './index.css';


// const PermCand = () => {
  
//   var varteste = '1';

//   return(

//     // UserAuth() === true &&
//     // ParseJwt.role 
//     varteste === '1' ?
//     <Route path='/Listar' name='Candidato' component={CandidatoListar} />
//     :
//     <Redirect to = '/login' />
    
//   )
// }
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
        <Route exact path='/'             name='Raiz'                   component={Login} />
        <Route path='/Login'              name='Login'                  component={Login} />
        <Route path='/Cadastrar'          name='Cadastrar'              component={Cadastrar} />
        
        <Route path='/Listar'             name='Candidato'              component={CandidatoListar} />
        <Route path='/ListarMinhas'       name='CandidatoMinhas'        component={CandidatoListarMinhas} />
        <Route path='/ListarCandidaturas' name='CandidatoCandidaturas'  component={CandidatoListarCandidaturas} />
        
        <Route path='/ListarRH'           name='RH'                     component={RHListar} />
        <Route path='/SelecionadosRH'     name='Selecionados'           component={CandidatosRH} />

        <Route path='/ListarLider'        name='Lider'                  component={LiderListar} />
        <Route path='/SelecionadosLider'  name='SelecionadosL'          component={LiderSelecionados} />
        
        <Redirect path='*' to='/'/>
      
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
