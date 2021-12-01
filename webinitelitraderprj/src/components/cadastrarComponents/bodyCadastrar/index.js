//Libs
import React from 'react'
import { useForm } from 'react-hook-form'

//Styles
import { Container, ContentLogin, SectionSubPerson, TopPerson, TittleSub, IconSubPerson, IconSubProf, IconSubLearn, SectionInformation, DataCand, WrapperForm, SubTittleSub, DataXp, InputDataXp, TittleInput, PreTittleInput, ButtonSub } from './styles'
// import { SectionSubExperience } from './stylesExperience'

//Components
import {Input} from '../../generic/input/styles'


export function ContentSubPerson(){

    const {register, handleSubmit} = useForm();

    function Continuar(data) {
        
        if(
            data.nome !== '' && 
            data.sobrenome !== '' &&
            data.cpf !== '' &&
            data.email !== ''
        ){

            // document.getElementById('CadCont').style.display = 'flex'
            console.log('renderiza')

        }else{

            console.log('nao renderiza')

        }

    }
    
    return(

        <SectionSubPerson id='cad'>

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
                    
                </DataCand >
                <DataXp onSubmit={handleSubmit(Continuar)}>
                    <InputDataXp >
                        <PreTittleInput>Formação 1</PreTittleInput>
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
                        <PreTittleInput>Formação 2</PreTittleInput>
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
                                <ButtonSub type='submit' value='Continuar'/>
                            </WrapperForm>
                    </InputDataXp>
                </DataXp>
            </SectionInformation>

        </SectionSubPerson>

    )

}

export function ContentSubExperience() {
    return(

        <SectionSubPerson id='cadCont'>

            <TopPerson>
                <TittleSub>Cadastre-se</TittleSub>
                <IconSubPerson/>
                <IconSubProf/>
                <IconSubLearn/>
            </TopPerson>
            <SectionInformation>

                <DataCand>

                    <SubTittleSub>Profissional</SubTittleSub>
                    
                </DataCand>


            </SectionInformation>

        </SectionSubPerson>
    )
}

export default function BodyLogin(){

    return(

        <Container>

            <ContentLogin>

                {/* <ContentSubPerson/> */}
                <ContentSubExperience/>
                    
            </ContentLogin>

        </Container>

    )

}