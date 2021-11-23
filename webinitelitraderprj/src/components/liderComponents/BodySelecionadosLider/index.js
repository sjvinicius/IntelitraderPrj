
// Libs
import React, { useState, useEffect } from 'react'

import { useHistory } from 'react-router-dom'

//Styles
import { Container, ContentAside, ImgUser, NameUser, TypeUser, Exit, WrapperNav, IconAllJob, IconMyJobs, TittleNav, Line, /* Fim Aside*/ WrapperContent, Logo, ListJob, CardJob, BackgroundCard, WrapperTittle, TittleJob, TabAction } from '../../candidatoComponents/bodyListar/styles'

import { ContainerModal, Top, IconClose, WrapperSection, SectionInfo, TittleJobModal, SubTittleJobModal, SubTittleJob, WrapperDesc, TextDesc, Text, Section, WrapperPerfis, CatIcon, WolfIcon, SharkIcon, EagleIcon } from '../../candidatoComponents/bodyListar/stylesModal'

import { WrapperModalPerfil, SectionModalPerfil, WrapperProfile, WrapperComp, IconWolfModal, IconEagleModal, WrapperInfosProfile, TextName, TextModalProfile } from '../../rhComponents/BodyListarRH/stylesModalPerfil'

import { WrapperModal, ListCand, Cand } from './styles'

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

function OpenPerfil() {
    
    document.getElementById('ModalPerfil').style.display = 'flex';

}

function ClosePerfil() {
    
    document.getElementById('ModalPerfil').style.display = 'none';

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
    
    function BuscarVaga() {
        
        setTittle('Desenvolvedor C#')
        setSubTittle('BackEnd')
    
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
                            value = {descricao}
                            
                            readOnly
                            disable
                            />
                        </WrapperDesc>
                        <ListCand>
                            <Cand src={foto} onClick={OpenPerfil}/>
                        </ListCand>
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

export function ModalPerfil() {
    
    return(

        <ContainerModal id='ModalPerfil'>
            <WrapperModalPerfil>
                <Top>
                    <IconClose onClick={ClosePerfil}/>
                </Top>
                <SectionModalPerfil>
                    <WrapperProfile>
                        <ImgUser src={foto}/>
                        <WrapperComp>
                            <IconWolfModal/>
                            <IconEagleModal/>
                        </WrapperComp>
                        <TextModalProfile>63%<br/>
                        Aderência</TextModalProfile>
                        <TextModalProfile>sjf.vinicius@gmail.com<br/>
                        (11) 9-5980-5820</TextModalProfile>
                    </WrapperProfile>
                    <WrapperInfosProfile>

                        <TextName>Vinicius Silva de Jesus</TextName>
                        <SubTittleJobModal>Desenvolvedor Front-End </SubTittleJobModal>

                        <Text>Tenho 20 anos e sou recém formado na aréa de tecnologia, estou em busca de uma oportunidade onde eu possa compartilhar meus conhecimentos aplicando no ambiente de trabalho e aprendendo mais com profissionais capacitados.</Text>

                        <Text>Técnico em Redes de Computadores<br/>
                        Escola SENAI de Informática<br/>
                        01/2019 - 06/2020</Text>
                        
                        <Text>Técnico em Redes de Computadores<br/>
                        Escola SENAI de Informática<br/>
                        01/2019 - 06/2020</Text>
                        
                        <Text>Técnico em Redes de Computadores<br/>
                        Escola SENAI de Informática<br/>
                        01/2019 - 06/2020</Text>
                        
                        <Text>Técnico em Redes de Computadores<br/>
                        Escola SENAI de Informática<br/>
                        01/2019 - 06/2020</Text>

                        <Text>Técnico em Redes de Computadores<br/>
                        Escola SENAI de Informática<br/>
                        01/2019 - 06/2020</Text>

                    </WrapperInfosProfile>
                </SectionModalPerfil>
            </WrapperModalPerfil>
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
                <TittleNav onClick={ () => { history.push('/ListarLider') } }>Todas as Vagas</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <IconMyJobs/>
                <TittleNav>Candidaturas</TittleNav>
            </WrapperNav>
            <Line/>

        </ContentAside>
    )

}



export default function BodySelecionadosLider() {
    
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
            <ModalPerfil/>
        </Container>
    )

}