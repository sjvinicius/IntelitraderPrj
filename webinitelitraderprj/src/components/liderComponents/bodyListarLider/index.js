
// Libs
import React, { useState, useEffect } from 'react'

import { useHistory } from 'react-router-dom'

import ReactTooltip from 'react-tooltip'

//Styles
import { Container, ContentAside, ImgUser, NameUser, TypeUser, Exit, WrapperNav, IconAllJob, IconMyJobs, TittleNav, Line, /* Fim Aside*/ WrapperContent, Logo, ListJob, CardJob, BackgroundCard, WrapperTittle, TittleJob, TabAction } from '../../candidatoComponents/bodyListar/styles'

import { ContainerModal, Top, IconClose, WrapperSection, SectionInfo, TittleJobModal, SubTittleJobModal, SubTittleJob, WrapperDesc, TextDesc, Text, Section, WrapperPerfis, CatIcon, WolfIcon, /*SharkIcon,*/ /*EagleIcon,*/ TextTooltip } from '../../candidatoComponents/bodyListar/stylesModal'

import { WrapperModal } from './styles'

//Imgs
import foto from '../../../img/Foto.jpg'

import logo from '../../../img/IntelitraderLogo.svg'

import bec from '../../../img/backendcard.png'

//Components
import { ButtonSmall, Button } from '../../generic/button/styles'

function OpenModal() {

    document.getElementById('Modal').style.display = 'flex';

}

function CloseModal() {

    document.getElementById('Modal').style.display = 'none';

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

    const history = useHistory()

    function LogOff(){

        localStorage.setItem('tkUserUp', '')

        history.push('/Login')

    }
    
    return (
        <ContentAside>
            
            <ImgUser src={foto} />
            <NameUser>Vinicius</NameUser>
            <TypeUser>Líder</TypeUser>
            <Exit onClick={LogOff}>Sair</Exit>

            <WrapperNav>
                <IconAllJob/>
                <TittleNav>Todas as Vagas</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <IconMyJobs/>
                <TittleNav onClick = { () => { history.push('/SelecionadosLider') } }>Candidaturas</TittleNav>
            </WrapperNav>
            <Line/>

        </ContentAside>
    )

}



export default function BodyListarLider() {
    
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

                </ListJob>

            </WrapperContent>
            <Modal/>
        </Container>
    )

}