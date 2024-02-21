[![Build](https://github.com/dss-extensions/dss_sharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/dss-extensions/dss_sharp/actions/workflows/dotnet.yml)
[![Latest NuGet release](https://img.shields.io/nuget/v/dss_sharp?label=NuGet+release&cacheSeconds=3600)](https://www.nuget.org/packages/dss_sharp/)

*For an English version of this file, see [README.md](https://github.com/dss-extensions/dss_sharp/blob/master/README.md).*

# DSS Sharp

DSS Sharp é um projeto para manter um assembly C#/.NET que exponha o motor do OpenDSS na sua implementação customizada da [biblioteca nativa DSS C-API](https://github.com/dss-extensions/dss_capi/blob/master/README.pt-BR.md). DSS C-API é um motor alternativo (sem suporte do EPRI) do OpenDSS: código aberto (totalmente), multiplataforma, multiarquitetura, com diversas extensões, e altamente compatível com a implementação oficial do OpenDSS conforme exposta em seu módulo COM.

Para compatibilidade, DSS Sharp tenta reproduzir a mesma interface/API que o módulo COM oficial do OpenDSS em nível de código do usuário, além de conter várias extensões (novas propriedades e métodos, e mesmo classes completas para alguns componentes de circuito). Se você encontrar comportamento conflitante além do documentado, sinta-se à vontade para entrar em contato ou [reportar no GitHub](https://github.com/dss-extensions/dss_sharp/issues).

Com exceção de gráficos e outros componentes visuais, este projeto expõe a maioria das funcionalidades implementadas na DSS C-API, incluindo algumas otimizações de desempenho, suporte a executar scripts .DSS dentro de arquivos ZIP, suporte inicial a exportação JSON, compatibilidade multiplataforma (Linux, Windows, macOS), includindo Intel x86/x64 e ARM. 
Ao contrário da implementação oficial, DSS Sharp suporta a criação de múltiplas instâncias independentes do motor do OpenDSS ([`dss_sharp.DSS.NewContext()`](https://dss-extensions.org/dss_sharp/html/d0e4d400-3bd9-1244-3cac-8f1234cbad9f.htm)), efetivamente permitindo que o usuário empregue aplicações com múltiplos threads de forma mais efetiva. A maioria das funções da versão PM do OpenDSS também estão [disponíveis](https://dss-extensions.org/dss_sharp/html/f3440753-3e74-bdb2-81c6-9052f8742d7e.htm).

Para uma introdução geral, visite https://dss-extensions.org e siga o desenvolvimento através da organização DSS-Extensions e https://github.com/dss-extensions/dss-extensions

<p align="center">
    <img alt="Visão geral dos repositórios" src="https://raw.githubusercontent.com/dss-extensions/dss_capi/master/docs/images/repomap.png" width=600>
</p>

Caso você tenha interesse em outras linguagens além de .NET:

- [DSS C-API library](http://github.com/dss-extensions/dss_capi/): a biblioteca base que expõe a versão modificada do OpenDSS através de uma interface C mais tradicional, criada empregando o compilador de código aberto Free Pascal ao invés do Delphi. Em 2023, contém diversas extensões e aprimoramentos, mantendo ainda boa compatibilidade.
- [dss.hpp](https://dss-extensions.org/dss_capi/): biblioteca de headers para C++, hospedada também neste repositório (pasta `include/`). Permite usar a DSS C-API de forma confortável sem ser necessário gerenciar os detalhes como o gerenciamento de memória ou convenção de API da DSS C-API. Atualmente usa Eigen e fmt.
- [DSS-Python](http://github.com/dss-extensions/dss_python/) é o módulo Python multi-plataforma (Windows, Linux, MacOS) bastante compatível com o módulo COM. Veja também [OpenDSSDirect.py](http://github.com/dss-extensions/OpenDSSDirect.py/) caso não precise de compatibilidade com COM, ou deseje empregar as funcionalidades extras do módulo (inclusive em conjunto). Há também o novo projeto [AltDSS-Python](http://github.com/dss-extensions/AltDSS-Python) que expande a API para todos os objetos DSS, manipulação de objetos em lote e mais.
- [OpenDSSDirect.jl](http://github.com/dss-extensions/OpenDSSDirect.jl/) é um módulo em Julia, criado por Tom Short (@tshort), que recentemente passou a empregar DSS C-API no lugar do DLL direto com a ajuda de Dheepak Krishnamurthy (@kdheepak).
- [DSS MATLAB](http://github.com/dss-extensions/dss_matlab/) permite integração multi-plataforma (Windows, Linux, MacOS) bastante compatível com a API do módulo COM oficial, de fato contorna algumas dificuldades de COM.
- [AltDSS-Rust](https://github.com/dss-extensions/AltDSS-Rust) e [AltDSS-Go](https://github.com/dss-extensions/AltDSS-Go) são dois novos projetos para linguagens Rust e Go.

# Documentação

Estamos criando documentação geral, inicialmente em inglês, em [https://github.com/dss-extensions/dss-extensions](https://github.com/dss-extensions/dss-extensions). Diversas notas e um FAQ já estão disponíveis. Há também espaço dedicado para discussões, etc.

No momento, os usuários podem seguir a documentação do módulo COM oficial do OpenDSS, pulando a parte de instalação. Caso não tenha OpenDSS instalado, os arquivos também estão disponíveis no [repositório SVN oficial](https://sourceforge.net/p/electricdss/code/HEAD/tree/trunk/Version8/Distrib/Doc/). 

Em geral atualizada alguns dias após o lançamento de uma nova versão, temos documentação das nossas classes de C#/.NET em https://dss-extensions.org/dss_sharp/

## Primeiros passos

Se você é um usuário novo de C# ou não tem usado em vários anos, é recomendável buscar por material atualizado sobre .NET e as práticas recomendadas para versões modernas.

Se ainda não é proficiente em OpenDSS, há dois principais aspectos a investigar:

- A linguagem DSS, que é usada para criar e editar os componentes dos circuitos elétricos, além de enviar comandos diversos para o motor do OpenDSS.
- As interfaces de programação (APIs), em especial a organização de classes e lógica empregada na API COM. As interfaces são usadas para automatizar ainda mais o uso do motor do DSS, extrair dados e integrar programas e bibliotecas de terceiros. As APIs atuais todas seguem o conceito de "objeto ativo" ("Active...") que pode ser novo para muitos usuários.
    - O DLL do módulo COM oficial está disponível apenas no Microsoft Windows ([COM é uma tecnologia da Microsoft](https://pt.wikipedia.org/wiki/Component_Object_Model)). DSS Sharp tenta reproduzir a mesma interface em nível do usuário sem depender de plataformas específicas — podemos usar Windows, Linux, or macOS, mesmo em processadores ARM.

A instalação da versão oficial do OpenDSS desenvolvida pelo EPRI contém bastante material para ambos os tópicos e, pulando a parte de instalação e registro do módulo COM (não necessário aqui), o material é aplicável para DSS Sharp e outras DSS-Extensions.

Usuários podem estudar e aprender os principais conceitos empregando a versão oficial e migrar para DSS Sharp quando necessário ou houver interesse de empregar as funcionalidades extras disponíveis nas DSS-Extensions.

### Instalação

Há múltiplas formas. Recomendamos empregar NuGet.

Se estiver usando versões recentes do Microsoft Visual Studio, pode [instalar empregando o pacote NuGet](https://www.nuget.org/packages/dss_sharp/). 

Caso esteja usando arquivos .csproj no estilo SDK, basta adicionar uma referência no XML como no exemplo abaixo (ajuste a versão de acordo com suas necessidades):

```xml
    <ItemGroup>
    <PackageReference Include="dss_sharp" Version="0.14.*" />
    </ItemGroup>
```

Por fim, se houver interesse em editar o código da DSS Sharp em si, após clonar lembra-se de baixar os DLLs necessários, seja usando o script `scripts/download_native_libs.sh`, ou visitando manualmente a [página de lançamentos da DSS C-API](https://github.com/dss-extensions/dss_capi/releases) para obter as versões necessárias. Alternativamente, copiar os DLLs do pacote NuGet pode ser mais prático.

### Uso mínimo

Após a instalação ou inclusão da referência ao `dss_sharp` no seu projeto, é possível testar a execução com um circuito qualquer.

Assumindo a instalação padrão do OpenDSS para todos os usuários na pasta `C:\Program Files`, o seguinte deve funcionar:

```cs
using dss_sharp;

//...

var dss = new DSS();
dss.Start(0);
dss.Text.Command = @"redirect 'C:\Program Files\OpenDSS\IEEETestCases\13Bus\IEEE13Nodeckt.dss'";
var voltageMags = dss.ActiveCircuit.AllBusVmag;
```

Você também pode baixar o repositório [electricdss-tst](https://github.com/dss-extensions/electricdss-tst) para obter os circuitos de teste e exemplos já ajustados para uso for multiplataforma (os arquivos originais são distribuídos com a instalação do OpenDSS oficial).

### Mais

Um exemplo simples mas quase passo a passo, está disponível aqui, apenas em inglês: [WinFormsAppSample](https://github.com/dss-extensions/dss_sharp/tree/master/examples/WinFormsAppSample)