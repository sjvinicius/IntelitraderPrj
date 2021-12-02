//Libs
import React from 'react'
import {useForm} from 'react-hook-form'
import {useHistory} from 'react-router-dom'

//Styles
import { Container, ContentLogin, SectionBanner, TittleInput, SectionLogin, Logo, FormLogin, WrapperAlignForm, WrapperBanner, WrapperAlign, SignUp, TittleBanner, Error, TextBanner, IconCoin, IconSearchMoney, IconTransact, IconPersonMoney, IconPerson, IconLock  } from './styles'

//Imgs
import logo from '../../../img/IntelitraderLogo.svg'

//Components
import {Input} from '../../generic/input/styles'
import {Button} from '../../generic/button/styles'

export default function BodyLogin(){

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

            <ContentLogin>

                <SectionBanner>

                    <TittleBanner>Conheça nossas oportunidades !</TittleBanner>

                    <WrapperBanner>
                        
                        <WrapperAlign>
                            <IconPersonMoney/>
                            <TextBanner>Cadastre-se em nosso site</TextBanner>
                        </WrapperAlign>
                        
                        
                        <WrapperAlign>
                            <IconSearchMoney/>
                            <TextBanner>Conheça a si mesmo</TextBanner>
                        </WrapperAlign>
                        
                        <WrapperAlign>
                            <IconTransact/>
                            <TextBanner>Candidate-se em nossas vagas</TextBanner>
                        </WrapperAlign>

                        <WrapperAlign>
                            <IconCoin/>
                            <TextBanner>Acompanhe seu processo</TextBanner>
                        </WrapperAlign>
                    </WrapperBanner>
                    
                </SectionBanner>

                <SectionLogin>

                    <Logo src={logo}/>
                    <FormLogin onSubmit={handleSubmit(Autenticar)}>

                        <TittleInput>Email</TittleInput>
                        <WrapperAlignForm>
                            <IconPerson />
                            <Input {...register('pwd')} type='email' />
                        </WrapperAlignForm>
                        
                        <TittleInput>Senha</TittleInput>
                        <WrapperAlignForm>
                            <IconLock />
                            <Input {...register('pwd')} type='password' />
                        </WrapperAlignForm>

                        <Error> {errorNull} </Error>

                        <Button value='Login' type='submit'/>

                        <SignUp onClick={ () => { history.push('/cadastrar') } } >Cadastre-se</SignUp>

                    </FormLogin>

                </SectionLogin>

            </ContentLogin>

        </Container>

    )

}