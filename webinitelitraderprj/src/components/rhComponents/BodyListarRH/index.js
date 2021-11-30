//Libs
import React, { useState, useEffect } from 'react'
import {useHistory} from 'react-router-dom'
import { useForm } from 'react-hook-form'
import ReactTooltip from 'react-tooltip'

//Styles
import { Container, WrapperContent, Logo, ListJob, CardJob, BackgroundCard, WrapperTittle, TittleJob, TabAction, ContentAside, ImgUser, NameUser, TypeUser, Exit, WrapperNav, IconAllJob, IconMyJobs, TittleNav, Line } from '../../candidatoComponents/bodyListar/styles'

import { ContainerModal,  Top, IconClose, WrapperSection, SectionInfo, TittleJobModal, SubTittleJobModal, SubTittleJob, WrapperDesc, TextDesc, Text, Section, WrapperPerfis, CatIcon, WolfIcon, /*SharkIcon,*/ /*EagleIcon,*/ TextTooltip } from '../../candidatoComponents/bodyListar/stylesModal'

import { WrapperAlign } from '../../loginComponents/bodyLogin/styles'

import { WrapperModal } from './stylesModal'

import { WrapperModalCad, SectionCad, TittleInputCad, TittleLabel, WrapperPerfil, SectionWrapperPerfil } from './stylesModalCad'

import { TittleNavNow } from '../../candidatoComponents/bodyListarMinhas/styles'

//Img
import logo from '../../../img/IntelitraderLogo.svg'
import bec from '../../../img/backendcard.png'
import foto from '../../../img/Foto.jpg'


//Components
import { ButtonSmall, Button, ButtonAside, ButtonCancel, ButtonCad } from '../../generic/button/styles'
import { InputCad, InputDesc, SelectCad, OptionCad, InputBoxCad } from '../../generic/input/styles'



function OpenModal() {
    
    document.getElementById('Modal').style.display = 'flex'

}

function CloseModal() {

    document.getElementById('Modal').style.display = 'none';

}

function OpenModalCadRH() {

    document.getElementById('ModalCadRH').style.display = 'flex'
    console.log('modal aberto')

}

function CloseModalCadRH() {

    document.getElementById('ModalCadRH').style.display = 'none'

}

export function ModalCadRH(){

    const { register } = useForm();

    return(

        <ContainerModal id='ModalCadRH'>
            <WrapperModalCad>
                <Top>
                    <IconClose onClick={CloseModalCadRH}/>
                </Top>
                <form>
                    <WrapperSection>
                        <SectionCad>
                            <TittleInputCad> Título </TittleInputCad>
                            <InputCad type='text' placeholder='Ex: Desenvolvedor C#' {...register('pwd')} />
                            
                            <TittleInputCad> Subtítulo </TittleInputCad>
                            <InputCad type='text' placeholder='Ex: BackEnd'{...register('pwd')} />

                            <TittleInputCad> Descrição </TittleInputCad>
                            <InputDesc type='text' placeholder='Ex: Vaga destinada ao candidato que tem experiencia em desenvolvimento de software backend' {...register('pwd')} />

                            <TittleInputCad> Salário </TittleInputCad>
                            <SelectCad placeholder='R$' type="number" {...register('pwd') }>
                                <OptionCad value="" disabled selected>Selecione uma Opção</OptionCad>
                                <OptionCad value='1'>R$500</OptionCad>
                                <OptionCad value='2'>R$500 ~ 1</OptionCad>
                                <OptionCad value='3'>R$1000 ~ 1500</OptionCad>
                                <OptionCad value='4'>R$1500 ~ 2000</OptionCad>
                                <OptionCad value='5'>&gt;R$2000</OptionCad>
                            </SelectCad>

                            <ButtonCancel value='cancelar' type='submit'/>

                        </SectionCad>
                        <SectionCad>
                            <TittleInputCad>Perfil Ideal</TittleInputCad>
                            <SectionWrapperPerfil>
                                <WrapperPerfil>

                                    <WrapperAlign>
                                        <InputBoxCad type="checkbox" />
                                        <TittleLabel>Organizado</TittleLabel>
                                    </WrapperAlign>
                                    <WrapperAlign>
                                        <InputBoxCad type="checkbox" />
                                        <TittleLabel>Planejador</TittleLabel>
                                    </WrapperAlign>
                                    <WrapperAlign>
                                        <InputBoxCad type="checkbox" />
                                        <TittleLabel>Criativo</TittleLabel>
                                    </WrapperAlign>
                                    <WrapperAlign>
                                        <InputBoxCad type="checkbox" />
                                        <TittleLabel>Comunicador</TittleLabel>
                                    </WrapperAlign>

                                </WrapperPerfil>
                                <WrapperPerfil>

                                    <WrapperAlign>
                                        <InputBoxCad id='checkCad' type="checkbox" />
                                        <TittleLabel>Empático</TittleLabel>
                                    </WrapperAlign>
                                    <WrapperAlign>
                                        <InputBoxCad id='checkCad' type="checkbox" />
                                        <TittleLabel>Curioso</TittleLabel>
                                    </WrapperAlign>
                                    <WrapperAlign>
                                        <InputBoxCad id='checkCad' type="checkbox" />
                                        <TittleLabel>Prático</TittleLabel>
                                    </WrapperAlign>
                                    <WrapperAlign>
                                        <InputBoxCad id='checkCad' type="checkbox" />
                                        <TittleLabel>Competitivo</TittleLabel>
                                    </WrapperAlign>

                                </WrapperPerfil>
                            </SectionWrapperPerfil>

                            <TittleInputCad> Tipo de Contrato </TittleInputCad>
                            <InputCad type='text' placeholder='Ex: CLT, Temporário' {...register('pwd')} />

                            <TittleInputCad> Hierarquia </TittleInputCad>
                            <InputCad type='text' placeholder='Ex: Júnior, Sênior, Pleno' {...register('pwd')} />
                            
                            <TittleInputCad> Área </TittleInputCad>
                            <InputCad type='text' placeholder='Ex: Administrativo, Tecnologia' {...register('pwd')} />

                            <ButtonCad value='Cadastrar' />

                        </SectionCad>
                    </WrapperSection>
                </form>
            </WrapperModalCad>
        </ContainerModal>

    )

}

export function Modal() {
    
    const [a, setTittle] = useState('')
    const [b, setSubTittle] = useState('')
    const [descricao] = useState(`Esta destinada a voce candidato(a) que está procurando pela primeira oportunidade de emprego acompanhe os requisitos
    
    Requisitos

    Conhecimentos em C# 
    Cursando Técnico ou Superior em Desenvolvimento
    Programação Orientada a Objetos
    Visual Studio Community
    GitHub
    Azure Devops
    Esta vaga esta destinada a voce candidato que está procurando pela primeira oportunidade de emprego acompanhe os requisitos`)
    const [lobo] = useState('Lobo: Analisa, quantifica, é lógico, é crítico, é realista, gosta de números, entende de dinheiro, sabe como as coisas funcionam. Gosta de trabalhar sozinho, realizar, analisar dados, lidar com aspectos financeiros, montar as coisas, fazer algo funcionar, resolver problemas difíceis. Como são pessoas muito objetivas, são perfeitas para atividades de execução, com escopo e prazos definidos.');
    const [gato] = useState(`Gato: É curioso, brinca, é sensível com os outros, gosta de ensinar, toca muito nas pessoas, gosta de apoiar, é expressivo, emocional, fala muito. Gosta de conseguir que os outros trabalhem bem juntos, de resolver questões de clientes, expressar ideias, desenvolver relacionamentos, fazer parte de uma equipe, convencer as pessoas, perceber o ambiente.`);

    async function BuscarVaga(id) {
        
        // const response = await api.get('/buscarvaga' + id, {

            // Headers : {

                // 'Authorization' : 'Bearer' + localStorage.getItem('tkUserUp')

            // }

        // })
        
        setTittle('Titulo')
        setSubTittle('Subtitulo')
    
    }

    useEffect( () => {
        
        BuscarVaga()
        
    },[])
    

    return(

        <ContainerModal id='Modal'>
            <WrapperModal>
                <Top>
                    <IconClose onClick={CloseModal}/>
                </Top>
                <WrapperSection>
                    <SectionInfo>
                        <TittleJobModal>{a}</TittleJobModal>
                        <SubTittleJobModal>{b}</SubTittleJobModal>
                        <WrapperDesc>
                            <TextDesc
                                value={descricao}by
                                readOnly
                                disable
                            />
                        </WrapperDesc>
                        <Text>R$a Salario</Text>
                    </SectionInfo>
                    <Section>
                        <WrapperPerfis>
                            <CatIcon data-tip data-for='CatTooltip'/>
                            <ReactTooltip id='CatTooltip'>
                                <TextTooltip>{gato}</TextTooltip>
                            </ReactTooltip>
                            <WolfIcon data-tip data-for='WolfTooltip' /> 
                            <ReactTooltip id='WolfTooltip'>
                                <TextTooltip>{lobo}</TextTooltip>
                            </ReactTooltip>
                            {/* <SharkIcon /> */}
                            {/* <EagleIcon /> */}
                        </WrapperPerfis>
                        <SubTittleJob> $Contrato </SubTittleJob>
                        <SubTittleJob> $Nível </SubTittleJob>
                        <SubTittleJob> $Area </SubTittleJob>
                        <SubTittleJob> $Local</SubTittleJob>
                        <Button 
                            disabled 
                            value='Candidatar' 
                            readOnly
                            style={{cursor: 'default'}}
                        />
                    </Section>
                </WrapperSection>
            </WrapperModal>
        </ContainerModal>

    )
    
}


function AsideMenu() {

    const history = useHistory();
    
    function LogOff(){

        localStorage.setItem('tkUserUp', '')

        history.push('/Login')

    }
    
    return (
        <ContentAside >
            
            <ImgUser src={foto} />
            <NameUser>Vinicius</NameUser>
            <TypeUser>Recursos Humanos</TypeUser>
            <Exit onClick={LogOff}>Sair</Exit>

            <WrapperNav>
                <IconAllJob/>
                <TittleNavNow onClick = { () => { history.push('/ListarRH') } }>Todas as Vagas</TittleNavNow>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <IconMyJobs/>
                <TittleNav onClick = { () => { history.push('/SelecionadosRH') } }>Selecionados</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <ButtonAside onClick = { OpenModalCadRH } value='Nova Vaga' readOnly/>
            </WrapperNav>

        </ContentAside>
    )

}


export default function BodyListarRH() {
    

    return(

        <Container>
            <AsideMenu/>
            <WrapperContent>
                <Logo src={logo}/>

                <ListJob>
                    
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>
                    <CardJob>
                        <BackgroundCard src={bec}/>
                            <WrapperTittle>
                                <TittleJob>Desenvolvedor BackEnd</TittleJob>
                            </WrapperTittle>
                        <TabAction>
                            <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                        </TabAction>
                    </CardJob>

                </ListJob>

            </WrapperContent>
            <Modal />
        </Container>

    )

}