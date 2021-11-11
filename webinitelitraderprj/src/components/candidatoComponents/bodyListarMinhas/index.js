//  Libs
import React, { /*useEffect*/ useState } from 'react'
import {useHistory} from 'react-router-dom'

// Styles 
import {TittleNavNow} from './styles'

import { ContentAside, ImgUser, NameUser, TypeUser, Exit, WrapperNav, IconAllJob, IconMyJobs, IconStatusJob, TittleNav, Line, /* Fim Aside */ Container, WrapperContent, Logo, ListJob, CardJob, BackgroundCard, WrapperTittle, TittleJob, TabAction } from '../bodyListar/styles'

import { ContainerModal, WrapperModal, Top, IconClose, WrapperSection, SectionInfo, TittleJobModal, SubTittleJobModal, SubTittleJob, WrapperDesc, TextDesc, Text, Section, WrapperPerfis, CatIcon, WolfIcon, SharkIcon, EagleIcon } from '../bodyListar/stylesModal'

import { Button } from '../../generic/button/styles'

//Img
import foto from '../../../img/Foto.jpg'
import logo from '../../../img/IntelitraderLogo.svg'
import bec from '../../../img/backendcard.png'

// Components
import { ButtonSmall } from '../../generic/button/styles'


function OpenModal() {
    
    document.getElementById('Modal').style.display = 'flex';
    
}

function CloseModal() {
    
    document.getElementById('Modal').style.display = 'none';
    
}



export function Modal() {
    
    const [a ] = useState(``)
    const [b ] = useState(``)
    const [descricao] = useState(`Esta destinada a voce candidato(a) que está procurando pela primeira oportunidade de emprego acompanhe os requisitos

    Requisitos

    Conhecimentos em C# 
    Cursando Técnico ou Superior em Desenvolvimento
    Programação Orientada a Objetos
    Visual Studio Community
    GitHub
    Azure Devops
    Esta vaga esta destinada a voce candidato que está procurando pela primeira oportunidade de emprego acompanhe os requisitos`)
    
    // async function BuscarVaga() {
        
    //     api.get('/buscarvagasminhas',{

    //         perfil1: tokenDecode(localStorage.getItem('tokenusrup')).perfil1,
    //         perfil2: tokenDecode(localStorage.getItem('tokenusrup')).perfil2

    //     })
    
    // }

    

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
    
    return (
        <ContentAside>
            
            <ImgUser src={foto} />
            <NameUser>Vinicius</NameUser>
            <TypeUser>Líder</TypeUser>
            <Exit>Sair</Exit>

            <WrapperNav>
                <IconAllJob/>
                <TittleNav onClick={ () => { history.push('/Listar') } }>Todas as Vagas</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <IconMyJobs/>
                <TittleNavNow onclick = { () => {history.push('/ListarMinhas')}}>Minhas vagas</TittleNavNow>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <IconStatusJob/>
                <TittleNav>Candidaturas</TittleNav>
            </WrapperNav>
            <Line/>

        </ContentAside>
    )

}

export default function BodyListarMinhas() {

    // useEffect( () => {
        
    //     // BuscarVaga()
        
    // },[])

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