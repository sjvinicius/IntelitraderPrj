# Projeto Intelitrader
## Descrição

Projeto de conclusão de curso de Desenvolvimento de Sistemas na Escola SENAI de Informática - 132, Foi designada uma equipe de alunos para receber um escopo da empresa Intelitrader e desenvolver uma solução para esse problema. Juntos utilizando metodologias e conhecimentos técnicos adquiridos ao longo do curso os alunos terão um período do dia 27/09 até 17/12 para desenvolver e apresentar essa solução para a empresa e outros telespectadores em escala nacional
Intelitrader
A Intelitrader é uma empresa do ramo financeiro e tecnológico que através de soluções são comercializadas como serviços. Serviços estes que estão focados em riscos de ações, plataformas de mercado online, trading por algoritimos e por ai a fora. A empresa foi fundada por Rodrigo Strauss com o objetivo de fazer software de alta performance para o mercado financeiro, quem estará em colaboração para os projetos será o Engenheiro de Softwares | Líder Técnico | Scrum Master Rodrigo Pereira acompanhando todo o processo de solução.
Escopo

### Objetivo

Sistema web de gerenciamento do funil de contratação, submissão de candidaturas, status do processo seletivo e status da contratação

### Descrição

O objetivo é a criação de uma plataforma WEB que centralize, simplifique e automatize o máximo possível o processo de contratação de um novo programador, desde o processo de candidatura, passando pelas etapas do processo seletivo, passando pelo período de experiência e chegando na efetivação. Deve ser possível gerenciar o candidato, a empresa, os desafios técnicos lançados e retornar o máximo de informações possíveis em relatórios e análises.
Problemas
Após a reunião do grupo discussão e aplicação do Design Thinking foram levantadas as seguintes problemáticas

### Onde os candidatos buscam as vagas ? (LinkeidIn, SENAI, Plataformas de Vagas)
Algumas empresas disponibilizam apenas um endereço de E-mail para envio das informações do candidato
 Processo de triagem do candidato
Conhecer o candidato processos.
Responder TODOS os candidatos
Solução

- O sistema exclusivo da empresa  de vagas soluciona o problema como em outras empresas em exemplo (Lorenzetti, Porto Seguro, Santander)
- Formulário com respostas alternativas com questões técnicas relacionadas a vaga de acordo com os requisitos técnicos do departamento
Questões Alternativas
Resultado Mínimo Para Ser Aprovado e Encaminhado ao RH
Através das respostas adicionar títulos técnicos alcançados (Conhecer o candidato)
Discord poderá solucionar um dos problemas de conhecimento  do candidato por parte pessoal
Deve ser considerado a possibilidade de conhecer os candidatos pessoalmente em um 2º entrevista diretamente no ambiente de trabalho
Avaliação através de uma escala por líderes e gestores, com uma justificativa. Será armazenado em um ambiente para os candidatos terem acesso, cujo RH terá acesso também à esses feedbacks.
Sprint 1

Objetivo: Juntar todas informações sobre o problema e planejar o projeto em um todo com três soluções possíveis, tivemos diversas reuniões para discutir o que poderia ser apresentado 


# Sprint 1
	
## 04/10/2021 ~ 22/10/2021

## Objetivo

asdasdsad

## Entrega

asjdansdasd


# Sprint 2
	
## 25/10/2021 ~ 19/11/2021

## Objetivo

Entrega Funcional do projeto.
Navegação do ambiente com segregação entre os tipos de usuários.
Infraestrutura mínima em nuvem pronta.

## Entrega

asjdansdasd


# Sprint 3
	
## 22/11/2021 ~ 10/12/2021

## Objetivo

asdasdsad

## Entrega

Preparação e dedicação para progredir o backend.
Migração completa para AWS.
Funcionalidades mínimas.
Geração do banco de dados.



# AWS

## Virtual Private Cloud (VPC)

Nosso bloco de endereço ficou 10.10.0.0/16.​
Subnetpub-a: 10.10.1.0/24
Subnetpub-b: 10.10.2.0/24
Subnetpub-c: 10.10.3.0/24
Subnetpub-d: 10.10.4.0/24
Subnetpriv-e: 10.10.5.0/24
Constitui em cinco Sub-rede, quatro pública e uma privada.​
Decidimos acrescentar 4 sub-rede pública visando a disponibilidade para futuras instâncias do Auto Scaling.


## Relational Database Service (RDS)

Utilizamos a Classe db.t2.micro, com 1 Gib de RAM, e 1 de  vCPU.​
Com 20 GB de armazenamento, e 20 GB para backup.​
No momento esta acessível ao público, para evitar de criar uma instância dentro da vpc apenas para acessar o banco, mas criamos regras de entrada permitindo apenas a equipe. 


## Elastic Compute Cloud (EC2)

Tipo da instância é um t2.micro, com 8GB de armazenamento.​
Instalamos o serviço apache2 para web.​
A instância esta na Sub-rede pública com IP privado 10.10.1.20./24.


## Elastic Load Balancing (ELB)

Decidimos usar o load balancing para dividir a carga entre as futuras instâncias do Auto Scaling quando houver pico de usuários, e também para deixar a url mais atrativa. 


## CloudWatch

É o nosso serviço de monitoramento, ele pode coletar e rastrear métricas.​
Ele esta configurado para mandar emails sobre o auto scaling.
Utilizaremos para monitorar o servidor web e o banco de dados por enquanto.
Optamos por usar esse serviço nativo da aws, pois não vimos a necessidade de subir mais uma instância para colocar apenas o serviço de monitoramento.



# BackEnd

asdnasdhansndadaada

## API

ajlsdnajsdnasdna

## Swagger

ajshdasjd

## Criptografia

asjdhasjkdhah



# FrontEnd
# INTELITRADER & Escola SENAI de Informática

##Telas

### Login

asadas


### Login

asdad


### Login

asdadas


### Login

asdasds


### Login

asdasd


### Login

asdasd

## Serviços 

aosjndklasdaksna
