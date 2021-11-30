//Libs
import React, { useState, useEffect } from 'react'
import {useHistory} from 'react-router-dom'
import { useForm } from 'react-hook-form'


//Styles
import { WrapperContent, Logo, ListJob, CardJob, BackgroundCard, WrapperTittle, TittleJob, TabAction, ContentAside, ImgUser, NameUser, TypeUser, Exit, WrapperNav, IconAllJob, IconMyJobs, TittleNav, Line } from '../../candidatoComponents/bodyListar/styles'

import { ContainerModal,  Top, IconClose, WrapperSection, SectionInfo, TittleJobModal, SubTittleJobModal, SubTittleJob, WrapperDesc, TextDesc, Text, Section, WrapperPerfis, CatIcon, WolfIcon, SharkIcon, EagleIcon } from '../../candidatoComponents/bodyListar/stylesModal'

import { WrapperModalPerfil, SectionModalPerfil, WrapperProfile, WrapperComp, IconWolfModal, IconEagleModal, WrapperInfosProfile, TextName, WrapperTech, TextModalProfile } from '../../rhComponents/BodySelecionados/stylesModalPerfil'

import { WrapperAlign } from '../../loginComponents/bodyLogin/styles'

import { WrapperModal, WrapperSubs, SubImg, IconCancel} from '../../rhComponents/BodySelecionados/stylesModal'

import { Container } from './styles'

import { WrapperModalCad, SectionCad, TittleInputCad, TittleLabel, WrapperPerfil, SectionWrapperPerfil } from '../../rhComponents/BodyListarRH/stylesModalCad'

import { TittleNavNow } from '../../candidatoComponents/bodyListarMinhas/styles'

//Img
import logo from '../../../img/IntelitraderLogo.svg'
import bec from '../../../img/backendcard.png'
import foto from '../../../img/Foto.jpg'


//Components
import { ButtonSmall, Button, ButtonModal, ButtonAside, ButtonCancel, ButtonCad } from '../../generic/button/styles'
import { InputCad, InputDesc, SelectCad, OptionCad, InputBoxCad } from '../../generic/input/styles'



function OpenModal() {
    
    document.getElementById('Modal').style.display = 'flex'

}

function OpenPerfil() {
    
    document.getElementById('ModalPerfil').style.display = 'flex';

}

function CloseModal() {

    document.getElementById('Modal').style.display = 'none';

}

function ClosePerfil() {
    
    document.getElementById('ModalPerfil').style.display = 'none';

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
            <ModalPerfil/>
        </ContainerModal>

    )

}

export function ModalRH() {

    const [descricao] = useState(`Esta destinada a voce candidato(a) que está procurando pela primeira oportunidade de emprego acompanhe os requisitos

    Requisitos

    Conhecimentos em C# 
    Cursando Técnico ou Superior em Desenvolvimento
    Programação Orientada a Objetos
    Visual Studio Community
    GitHub
    Azure Devops
    Esta vaga esta destinada a voce candidato que está procurando pela primeira oportunidade de emprego acompanhe os requisitos`)

    const [a, setTittle] = useState('')
    const [b, setSubTittle] = useState('')
    
    function BuscarVaga() {
        
        setTittle('Titulo')
        setSubTittle('SubTitulo')
    
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
                        <WrapperSubs>
                            <SubImg onClick={OpenPerfil} src={foto}/>
                            <ButtonModal value='Aprovado' readOnly/>
                            <IconCancel/>
                        </WrapperSubs>
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
                        <Button 
                            disabled 
                            value='Candidatar' 
                            readOnly
                            style={{cursor: 'default'}}
                        />
                    </Section>
                </WrapperSection>
            </WrapperModal>
            <ModalPerfil/>
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

                        <WrapperTech>
                            <TextName>Experiência</TextName>
                            <Text>Técnico em Redes de Computadores<br/>
                            Escola SENAI de Informática<br/>
                            01/2019 - 06/2020</Text>
                            
                            <Text>Técnico em Redes de Computadores<br/>
                            Escola SENAI de Informática<br/>
                            01/2019 - 06/2020</Text>
                            
                            <Text>Técnico em Redes de Computadores<br/>
                            Escola SENAI de Informática<br/>
                            01/2019 - 06/2020</Text>
                            
                            <TextName>Aprendizagem</TextName>
                            <Text>Técnico em Redes de Computadores<br/>
                            Escola SENAI de Informática<br/>
                            01/2019 - 06/2020</Text>
                            
                            <Text>Técnico em Redes de Computadores<br/>
                            Escola SENAI de Informática<br/>
                            01/2019 - 06/2020</Text>

                            <Text>Técnico em Redes de Computadores<br/>
                            Escola SENAI de Informática<br/>
                            01/2019 - 06/2020</Text>
                        </WrapperTech>
                    </WrapperInfosProfile>
                </SectionModalPerfil>
            </WrapperModalPerfil>
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
                <TittleNav onClick = { () => { history.push('/ListarRH') } }>Todas as Vagas</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <IconMyJobs/>
                <TittleNavNow onClick = { () => { history.push('/SelecionadosRH') } }>Selecionados</TittleNavNow>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <ButtonAside onClick = { OpenModalCadRH } value='Nova Vaga' readOnly/>
            </WrapperNav>

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
            <ModalRH />
            <ModalCadRH />
        </Container>

    )

}