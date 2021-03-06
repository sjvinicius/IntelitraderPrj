//Libs
import React, { useState } from 'react'
import { useForm } from 'react-hook-form'
import ReactTooltip from 'react-tooltip'

//Styles
import { Container, ModalCad, ModalCont, ContentLogin, SectionSubPerson, TopPerson, TittleSub, /*IconSubPerson*/ IconSubPersonA, IconSubProf, IconSubProfA, IconSubLearn, /*IconSubLearnA*/ SectionInformation, DataCand, DataCandCad, WrapperExp, WrapperSectionInput, SubTittleSub, WrapperInput, DataXp, InputDataXp, TittleInput, PreTittleInput, ButtonSub, InputSub, ButtonSubCont, IconBack, ACContent, WrapperPerfis, WrapperNav } from './styles'
import { SectionQuestions, WrapperQuestions, Question, WrapperOptions, InputQuestion, LabelQuestion } from './stylesQuestions'
import { TextTooltip } from '../../candidatoComponents/bodyListar/stylesModal'

//Components
import {Input, InputDesc} from '../../generic/input/styles'
import {Button} from '../../generic/button/styles'
import { EagleIcon, WolfIcon, SharkIcon, CatIcon} from '../../candidatoComponents/bodyListar/stylesModal'


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
            document.getElementById('cad').style.display = 'none'
            document.getElementById('cadCont').style.display = 'flex'

        }else{

            console.log('nao renderiza')

        }

    }
    
    return(

        <ModalCad id='cad'>

            <SectionSubPerson>

                <TopPerson>
                    <TittleSub>Cadastre-se</TittleSub>
                    <IconSubPersonA/>
                    <IconSubProf/>
                    <IconSubLearn/>
                </TopPerson>
                <SectionInformation onSubmit={handleSubmit(Continuar)}>
                    <DataCandCad>
                        <SubTittleSub>Pessoal</SubTittleSub>
                        
                        <TittleInput>Nome *</TittleInput>
                        <Input {...register('nome')}/>
                        <TittleInput>Sobrenome</TittleInput>
                        <Input {...register('sobrenome')}/>
                        <TittleInput>CPF *</TittleInput>
                        <Input {...register('cpf')}/>
                        <TittleInput>Email *</TittleInput>
                        <Input {...register('email')}/>
                        
                    </DataCandCad >
                    <DataXp>
                        <InputDataXp >
                            <PreTittleInput>Formação 1</PreTittleInput>

                            <TittleInput>Curso</TittleInput>
                            <Input {...register('f1curso')}/>
                            <TittleInput>Instituição</TittleInput>
                            <Input {...register('f1instituicao')}/>
                            <TittleInput>Início</TittleInput>
                            <Input {...register('f1inicio')}/>
                            <TittleInput>Fim</TittleInput>
                            <Input {...register('f1fim')}/>
                        </InputDataXp>
                            
                        <InputDataXp>
                            <PreTittleInput>Formação 2</PreTittleInput>
                            <TittleInput>Curso</TittleInput>
                            <Input {...register('f2curso')}/>
                            <TittleInput>Instituição</TittleInput>
                            <Input {...register('f2instituicao')}/>
                            <TittleInput>Início</TittleInput>
                            <Input {...register('f2inicio')}/>
                            <TittleInput>Fim</TittleInput>
                            <Input {...register('f2fim')}/>
                            <ButtonSub type='submit' value='Continuar'/>
                        </InputDataXp>
                    </DataXp>
                </SectionInformation>

            </SectionSubPerson>
        </ModalCad>
    )

}

export function ContentSubExperience() {

    const {/*register,*/ handleSubmit} = useForm();

    function BackCad(){

        document.getElementById('cad').style.display = 'flex'
        document.getElementById('cadCont').style.display = 'none'

    }

    function CadCont(){

        document.getElementById('cadCont').style.display = 'none';
        document.getElementById('infoAuto').style.display = 'flex';


    }

    return(

        <ModalCont id='cadCont'>
            <SectionSubPerson>

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
                                <InputSub type='date'/>
                            </WrapperInput>
                            <WrapperInput>
                                <TittleInput>Fim</TittleInput>
                                <InputSub type='date'/>
                            </WrapperInput>
                            
                            <IconBack onClick={BackCad}/>

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
                                    <InputSub type='date'/>
                                </WrapperInput>
                                <WrapperInput>
                                    <TittleInput>Fim</TittleInput>
                                    <InputSub type='date'/>
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
                                    <InputSub type='date'/>
                                </WrapperInput>
                                <WrapperInput>
                                <TittleInput>Fim</TittleInput>
                                <InputSub type='date'/>
                                </WrapperInput>
                            </WrapperExp>
                            
                        </WrapperSectionInput>
                        <ButtonSubCont type='submit' value='Continuar'/>
                        

                    </DataCand>

                </SectionInformation>

            </SectionSubPerson>
        </ModalCont>
    )
}

export function ContentAutoConhecimento(){

    const [gato] = useState(`Trabalhar em equipe e comunicação aberta.`);
    const [lobo] = useState(`Pensar em longo prazo e cumprir com regras e responsabilidade.`);
    const [tubarao] = useState(`Fazer com que os processos ou projetos aconteçam e conseguir parar com a burocracia.`);
    const [aguia] = useState(`Provocar mudanças radicais e antecipar o futuro.`);

    function BackExp(){

        document.getElementById('infoAuto').style.display = 'none'
        document.getElementById('cadCont').style.display = 'flex'

    }

    return(

        <ACContent id='infoAuto'>
            
            <TittleSub>Autoconhecimento</TittleSub>

            <PreTittleInput>

                Autonhecimento é um tema pouco citado nos ambientes de aprendizagem e introdução no mercado de trabalho, é de suma importância que todos profissionais estejam abertos a se conhecer para que assim seja possível apresentar-se e deixar explícito os pontos fortes e pontos de melhoria. É importante  ressaltar que não existe um perfil melhor ou mais apto do que outro, existem perfis diferentes para atividades diferentes, todos são capazes de alcançar o resultado a diferença está nos métodos, facilidades e dificuldades percorridas. Durante este processo de seleção você terá a oportunidade de se autoconhecer através do teste de perfil comportamental de Ned Hermann, para evitar fraudes e falta de precisão no teste maiores informações serão passadas após o resultado do teste.

            </PreTittleInput>

            <WrapperPerfis>

                <WolfIcon data-tip data-for='WolfTooltip'/>
                <ReactTooltip id='WolfTooltip'>
                    <TextTooltip>{lobo}</TextTooltip>
                </ReactTooltip>

                <SharkIcon data-tip data-for='SharkTooltip'/>
                <ReactTooltip id='SharkTooltip'>
                    <TextTooltip>{tubarao}</TextTooltip>
                </ReactTooltip>

                <CatIcon data-tip data-for='CatTooltip'/>
                <ReactTooltip id='CatTooltip'>
                    <TextTooltip>{gato}</TextTooltip>
                </ReactTooltip>

                <EagleIcon data-tip data-for='EagleTooltip'/>
                <ReactTooltip id='EagleTooltip'>
                    <TextTooltip>{aguia}</TextTooltip>
                </ReactTooltip>

            </WrapperPerfis>

            <PreTittleInput>
                Responda as questão relacionando sempre à você, não a resposta mais bondosa, ou generosa, apenas a que mais é relacionada à você.
            </PreTittleInput>

            <WrapperNav>
                <IconBack onClick={BackExp}/>
                <Button value='Ir Para o Teste'/>
            </WrapperNav>

        </ACContent>

    )

}

export function BodyQuestions(){

    var [L] = useState(0)
    var [G] = useState(0)
    var [T] = useState(0)
    var [A] = useState(0)

    return(

        <SectionQuestions>

            <TittleSub>Cadastre-se</TittleSub>
            <SubTittleSub>AutoConhecimento</SubTittleSub>
            
            <WrapperQuestions>

                <Question>
                    <PreTittleInput>1. Eu sou...</PreTittleInput>
                    <input name="comportamento" type="radio"/>
                    <LabelQuestion>Idealista, criativo e visionário</LabelQuestion>
                    <input name="comportamento" type="radio"/>
                    <LabelQuestion>Divertido, espiritual e benéfico</LabelQuestion>
                    <input name="comportamento" type='radio'/>
                    <LabelQuestion>Confiável, meticuloso e previsível</LabelQuestion>
                    <input name="comportamento" type='radio'/>
                    <LabelQuestion>Focado, determinado e persistente</LabelQuestion>
                </Question>
                
                <Question>
                <PreTittleInput>2. Eu gosto de...</PreTittleInput>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Ser piloto</LabelQuestion>
                    </WrapperOptions>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Divertido, espiritual e benéfico</LabelQuestion>
                    </WrapperOptions>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Confiável, meticuloso e previsível</LabelQuestion>
                    </WrapperOptions>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Focado, determinado e persistente</LabelQuestion>
                    </WrapperOptions>
                </Question>
                
                <Question>
                <PreTittleInput>2. Eu gosto de...</PreTittleInput>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Ser piloto</LabelQuestion>
                    </WrapperOptions>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Divertido, espiritual e benéfico</LabelQuestion>
                    </WrapperOptions>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Confiável, meticuloso e previsível</LabelQuestion>
                    </WrapperOptions>
                    <WrapperOptions>
                        <InputQuestion type='radio'/>
                        <LabelQuestion>Focado, determinado e persistente</LabelQuestion>
                    </WrapperOptions>

                    <Button value=''/>
                </Question>

            </WrapperQuestions>

        </SectionQuestions>

    )

}

export default function BodyLogin(){

    return(

        <Container>

            <ContentLogin>

                {/* <ContentSubPerson/> */}
                {/* <ContentSubExperience/> */}
                {/* <ContentAutoConhecimento/> */}
                <BodyQuestions/>
                    
            </ContentLogin>

        </Container>

    )

}