// Libs
import React from 'react'
import { useForm } from 'react-hook-form'
import { useHistory } from 'react-router-dom'

// Styles
import { Container, Logo, Error, FormLogin, TittleInput, WrapperAlign, IconUser, IconPwd, SignUp } from './styles'

// Components
import { Input } from '../../generic/input/styles'
import { Button } from '../../generic/button/styles'

//Img
import logo from '../../../img/IntelitraderLogo.svg'


export default function BodyLogin () {

    const {register, handleSubmit} = useForm()
    const history = useHistory()
    var errorNull = ''

    //Funcoes
    async function Autenticar(data){

        // const response = await api.get('/Autentic', 
        //     {
        //         email : data.email,
        //         senha : data.pwd   
        //     }
        // )

        if(data.email === '' || data.pwd === ''){

            errorNull = 'Preencha todos os campos antes de continuar'
            
        }else{
            
            console.log(data.email + '' + data.pwd)
            history.push('/Listar')

        }
        


    }

    return(

        <Container>
            <Logo src={logo}/>
            <FormLogin onSubmit={handleSubmit(Autenticar)} >
                <Error> {errorNull} </Error>
                <TittleInput> Email </TittleInput>
                <WrapperAlign>
                    <IconUser />
                    <Input type='email' {...register('email')} />
                </WrapperAlign>
                <TittleInput> Senha </TittleInput>
                <WrapperAlign>
                    <IconPwd/>
                    <Input type='password' {...register('pwd')} />
                </WrapperAlign>
                <Button type='submit' value='Entrar' readOnly/>
            </FormLogin>
            <SignUp> Cadastre-se </SignUp>
        </Container>

    )

}