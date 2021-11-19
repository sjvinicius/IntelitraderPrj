//  Libs
import React, { useEffect, useState } from 'react'
import { useHistory } from 'react-router-dom'

// Styles 
import { ContentAside, ImgUser, NameUser, TypeUser, Exit, WrapperNav, IconAllJob, IconMyJobs, IconStatusJob, TittleNav, Line, /* Fim Aside */ Container, WrapperContent, Logo, ListJob, CardJob, BackgroundCard, WrapperTittle, TittleJob, TabAction } from './styles'

import { ContainerModal, WrapperModal, Top, IconClose, WrapperSection, SectionInfo, TittleJobModal, SubTittleJobModal, SubTittleJob, WrapperDesc, TextDesc, Text, Section, WrapperPerfis, CatIcon, WolfIcon, SharkIcon, EagleIcon } from './stylesModal'

import { TittleNavNow } from '../bodyListarMinhas/styles'

import { Button } from '../../generic/button/styles'

//Img
import foto from '../../../img/Foto.jpg'
import logo from '../../../img/IntelitraderLogo.svg'
import bec from '../../../img/backendcard.png'

// Components
import { ButtonSmall } from '../../generic/button/styles'

//Services
import {api} from '../../../services/api/api'



function CloseModal() {
    
    document.getElementById('Modal').style.display = 'none';
    
}

function OpenModal() {

    document.getElementById('Modal').style.display = 'flex';

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
    
    async function BuscarVaga(id) {
        
        const response = await api.get('/buscarvaga' + id, {

            Headers : {

                'Authorization' : 'Bearer' + localStorage.getItem('tkUserUp')

            }

        })
        
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
                                value={descricao}
                                readOnly
                                disable
                            />
                        </WrapperDesc>
                        <Text>R$a Salario</Text>
                    </SectionInfo>
                    <Section>
                        <WrapperPerfis>
                            <CatIcon />
                            <WolfIcon />
                            <SharkIcon />
                            <EagleIcon />
                        </WrapperPerfis>
                        <SubTittleJob> $Contrato </SubTittleJob>
                        <SubTittleJob> $Nível </SubTittleJob>
                        <SubTittleJob> $Area </SubTittleJob>
                        <SubTittleJob> $Local</SubTittleJob>
                        <Button value='Candidatar' readOnly/>
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
            <TypeUser>Candidato</TypeUser>
            <Exit onClick={LogOff}>Sair</Exit>

            <WrapperNav >
                <IconAllJob/>
                <TittleNavNow>Todas as Vagas</TittleNavNow>
            </WrapperNav>
            <Line/>
            <WrapperNav onClick = { () => {history.push('/ListarMinhas')} }>
                <IconMyJobs/>
                <TittleNav>Minhas vagas</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav onClick = { () => {history.push('/ListarCandidaturas')} }>
                <IconStatusJob/>
                <TittleNav>Candidaturas</TittleNav>
            </WrapperNav>
            <Line/>

        </ContentAside>
    )

}

export default function BodyListar () {

    return (

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