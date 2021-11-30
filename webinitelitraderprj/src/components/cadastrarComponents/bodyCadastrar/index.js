//Libs
import React from 'react'
import {useForm} from 'react-hook-form'

//Styles
import { Container, ContentLogin, SectionSubPerson, TopPerson, TittleSub, IconSubPerson, IconSubProf, IconSubLearn, SectionInformation, DataCand, WrapperForm, SubTittleSub, DataXp, InputDataXp, TittleInput, ButtonSub, FooterSub } from './styles'

//Components
import {Input} from '../../generic/input/styles'


export function ContentSubPerson(){
    const {register, handleSubmit} = useForm();

    function Continuar(data) {
        
        if(
            // data.nome != null 
            // || 
            data.nome !== '' && 
            // data.sobrenome != null 
            // || 
            data.sobrenome !== '' &&
            // data.cpf != null 
            // || 
            data.cpf !== '' &&
            // data.email != null 
            // || 
            data.email !== ''
        ){

            console.log('renderiza cada 2')

        }else{

            console.log('nao renderiza')

        }

    }
    
    return(

        <SectionSubPerson>

            <TopPerson>
                <TittleSub>Cadastre-se</TittleSub>
                <IconSubPerson/>
                <IconSubProf/>
                <IconSubLearn/>
            </TopPerson>
            <SectionInformation>
                <DataCand>
                    <SubTittleSub>Pessoal</SubTittleSub>
                    
                    <TittleInput>Nome</TittleInput>
                    <Input {...register('nome')}/>
                    <TittleInput>Sobrenome</TittleInput>
                    <Input {...register('sobrenome')}/>
                    <TittleInput>CPF</TittleInput>
                    <Input {...register('cpf')}/>
                    <TittleInput>Email</TittleInput>
                    <Input {...register('email')}/>
                    
                </DataCand>
                <DataXp>
                    <InputDataXp onSubmit={handleSubmit(Continuar)}>
                        <TittleInput>Formação 1</TittleInput>
                            <WrapperForm>
                                <TittleInput>Curso</TittleInput>
                                <Input {...register('f1curso')}/>
                                <TittleInput>Instituição</TittleInput>
                                <Input {...register('f1instituicao')}/>
                            </WrapperForm>
                            <WrapperForm>
                                <TittleInput>Início</TittleInput>
                                <Input {...register('f1inicio')}/>
                                <TittleInput>Fim</TittleInput>
                                <Input {...register('f1fim')}/>
                            </WrapperForm>
                        </InputDataXp>
                        
                        <InputDataXp>
                        <TittleInput>Formação 2</TittleInput>
                            <WrapperForm>
                                <TittleInput>Curso</TittleInput>
                                <Input {...register('f2curso')}/>
                                <TittleInput>Instituição</TittleInput>
                                <Input {...register('f2instituicao')}/>
                            </WrapperForm>
                            <WrapperForm>
                                <TittleInput>Início</TittleInput>
                                <Input {...register('f2inicio')}/>
                                <TittleInput>Fim</TittleInput>
                                <Input {...register('f2fim')}/>
                            </WrapperForm>
                    </InputDataXp>
                </DataXp>
            </SectionInformation>
            <FooterSub>
                <ButtonSub type='submit' value='Continuar'/>
            </FooterSub>

        </SectionSubPerson>

    )

}

export default function BodyLogin(){

    return(

        <Container>

            <ContentLogin>

                <ContentSubPerson/>
                    
            </ContentLogin>

        </Container>

    )

}