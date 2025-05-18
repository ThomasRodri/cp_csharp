# 📄 IDEIA DO PROJETO - CP2 - ADVANCED BUSINESS DEVELOPMENT WITH .NET

Rastreamento de motos


👥 INTEGRANTES DO GRUPO
===========================

- RM558042 - Thomas Rodrigues Ribeiro Silva
- RM554727  - João Victor Rocha Cândido


📘 TÍTULO DO PROJETO
===========================

Sistema de Mapeamento Inteligente de Motos no Pátio – Mottu


🎯 PROBLEMA A SER RESOLVIDO
===========================

A Mottu precisa saber com precisão onde cada moto está estacionada em seus pátios espalhados pelo Brasil e México. 
O processo atual é manual e impreciso, impactando diretamente a agilidade, segurança e controle da operação. 
É necessário um sistema automatizado, escalável e integrado com tecnologias modernas para gerenciar essas informações.


💡 SOLUÇÃO PROPOSTA
===========================

Desenvolveremos uma API RESTful com .NET 8 utilizando Clean Architecture, com base de dados Oracle via EF Core. 

O sistema permitirá:
- Registro de motos, filiais e suas localizações dentro dos pátios.
- Atualização e consulta da posição de cada moto em tempo real.
- Visualização da estrutura de cada pátio e distribuição das motos.
- Integração futura com sensores IoT embarcados nas motos.
- Facilidade de acesso por meio de interface web ou mobile (em etapas futuras).

Com isso, a Mottu poderá:
- Aumentar a precisão no controle das motos.
- Otimizar a logística interna.
- Reduzir o tempo de localização e alocação dos veículos.
- Facilitar a expansão do sistema para mais de 100 filiais.


📐 ENTIDADES PRINCIPAIS
===========================

- *Moto*: Id, Placa, Modelo, Status, IdFilial, IdLocalizacao
- *Filial*: Id, Nome, Endereço, Capacidade
- *LocalizacaoPatio*: Id, Coordenada (ou descrição do ponto), IdFilial, Ocupada, MotoId


🛠 TECNOLOGIAS E ESTRUTURA
===========================

- .NET 8
- EF Core com Oracle
- Swagger para documentação da API
- Clean Architecture (Domain, Application, Infrastructure, Presentation)
- DTOs para comunicação segura entre camadas
- Migrations para versionamento do banco de dados
- Variáveis de ambiente para configuração da connection string (evitando exposição)
- Camada de serviço com interfaces e repositórios


📌 OBSERVAÇÕES FINAIS
===========================

- O projeto está preparado para integração futura com sensores IoT e visão computacional.
- A estrutura foi projetada visando escalabilidade e manutenção.
- As funcionalidades básicas já estão implementadas, como registro e consulta de motos, filiais e localizações.
- A utilização do Oracle e práticas seguras como variáveis de ambiente garantem a viabilidade real da solução.
