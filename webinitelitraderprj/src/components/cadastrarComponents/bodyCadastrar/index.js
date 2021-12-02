//Libs
import React from 'react'
import { useForm } from 'react-hook-form'

//Styles
import { Container, ContentLogin, SectionSubPerson, TopPerson, TittleSub, IconSubPerson, IconSubPersonA, IconSubProf, IconSubProfA, IconSubLearn, IconSubLearnA, SectionInformation, DataCand, WrapperExp, WrapperSectionInput, WrapperForm, SubTittleSub, WrapperInput, DataXp, InputDataXp, TittleInput, PreTittleInput, ButtonSub, InputSub, ButtonSubCont } from './styles'
// import { SectionSubExperience } from './stylesExperience'

//Components
import {Input, InputDesc} from '../../generic/input/styles'


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
                <IconSubPersonA/>
                <IconSubProf/>
                <IconSubLearn/>
            </TopPerson>
            <SectionInformation onSubmit={handleSubmit(Continuar)}>
                <DataCand>
                    <SubTittleSub>Pessoal</SubTittleSub>
                    
                    <TittleInput>Nome *</TittleInput>
                    <Input {...register('nome')}/>
                    <TittleInput>Sobrenome</TittleInput>
                    <Input {...register('sobrenome')}/>
                    <TittleInput>CPF *</TittleInput>
                    <Input {...register('cpf')}/>
                    <TittleInput>Email *</TittleInput>
                    <Input {...register('email')}/>
                    
                </DataCand >
                <DataXp>
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

    const {register, handleSubmit} = useForm();

    function CadCont(){

        console.log('botao')

    }

    return(

        <SectionSubPerson id='cadCont'>

            <TopPerson>
                <TittleSub>Cadastre-se</TittleSub>
                <IconSubPersonA/>
                <IconSubProfA/>
                <IconSubLearn/>
            </TopPerson>
            <SectionInformation onSubmit={handleSubmit(CadCont)}>

                <DataCand>
                    
                    <SubTittleSub>Profissional</SubTittleSub>
                    <TittleInput>Informações Complementares *</TittleInput>
                    <InputDesc />
                    <PreTittleInput>Experiência 1</PreTittleInput>
                    <WrapperExp>
                        <WrapperInput>
                            <TittleInput>Cargo</TittleInput>
                            <InputSub/>
                        </WrapperInput>
                        <WrapperInput>
                            <TittleInput>Empresa</TittleInput>
                            <InputSub/>
                        </WrapperInput>
                        <WrapperInput>
                            <TittleInput>Início</TittleInput>
                            <InputSub/>
                        </WrapperInput>
                        <WrapperInput>
                            <TittleInput>Fim</TittleInput>
                            <InputSub/>
                        </WrapperInput>
                    </WrapperExp>
                    

                </DataCand>
                <DataCand>
                        <PreTittleInput>Experiência 2</PreTittleInput>
                        
                        <WrapperExp>
                            <WrapperInput>
                                <TittleInput>Cargo</TittleInput>
                                <InputSub/>
                            </WrapperInput>
                            <WrapperInput>
                                <TittleInput>Empresa</TittleInput>
                                <InputSub/>
                            </WrapperInput>
                            <WrapperInput>
                                <TittleInput>Início</TittleInput>
                                <InputSub/>
                            </WrapperInput>
                            <WrapperInput>
                                <TittleInput>Fim</TittleInput>
                                <InputSub/>
                            </WrapperInput>
                        </WrapperExp>
                    
                    
                    <WrapperSectionInput>
                    
                        <PreTittleInput>Experiência 3</PreTittleInput>
                        
                        <WrapperExp>
                            <WrapperInput>
                                <TittleInput>Cargo</TittleInput>
                                <InputSub/>
                            </WrapperInput>
                            <WrapperInput>
                                <TittleInput>Empresa</TittleInput>
                                <InputSub/>
                            </WrapperInput>
                            <WrapperInput>
                                <TittleInput>Início</TittleInput>
                                <InputSub/>
                            </WrapperInput>
                            <WrapperInput>
                            <TittleInput>Fim</TittleInput>
                            <InputSub/>
                            </WrapperInput>
                        </WrapperExp>
                        
                    </WrapperSectionInput>
                    <ButtonSubCont type='submit' value='Continuar'/>
                    

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