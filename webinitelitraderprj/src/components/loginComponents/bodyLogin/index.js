//Libs
import React from 'react'

//Styles
import { Container, ContentLogin, SectionBanner, SectionLogin, Logo, FormLogin, WrapperAlign, SignUp, TittleBanner,/*Icon,*/ TextBanner} from './styles'

//Imgs
// import {} from ''

//Components
import {Input} from '../../generic/input/styles'
import {Button} from '../../generic/button/styles'

export default function BodyLogin(){

    return(

        <Container>

            <ContentLogin>

                <SectionBanner>

                    <TittleBanner>Conheça nossas oportunidades !</TittleBanner>

                        <WrapperAlign>
                            {/* <Icon/> */}
                            <TextBanner>Cadastre-se em nosso site</TextBanner>
                        </WrapperAlign>
                        
                        <WrapperAlign>
                            {/* <Icon/> */}
                            <TextBanner>Conheça a si mesmo</TextBanner>
                        </WrapperAlign>
                        
                        <WrapperAlign>
                            {/* <Icon/> */}
                            <TextBanner>Candidate-se em nossas vagas</TextBanner>
                        </WrapperAlign>

                        <WrapperAlign>
                            {/* <Icon/> */}
                            <TextBanner>Acompanhe seu processo</TextBanner>
                        </WrapperAlign>
                    
                </SectionBanner>

                <SectionLogin>

                    <Logo/>
                    <FormLogin>

                        <WrapperAlign>
                            <Input />
                        </WrapperAlign>
                        
                        <WrapperAlign>
                            <Input />
                        </WrapperAlign>

                        <Button />

                        <SignUp>Cadastre-se</SignUp>

                    </FormLogin>

                </SectionLogin>

            </ContentLogin>

        </Container>

    )

}