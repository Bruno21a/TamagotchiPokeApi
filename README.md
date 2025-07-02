# 🐾 Tamagotchi Pokémon - Console Game

Um jogo interativo de console em C# que permite adotar Pokémons como mascotes virtuais e cuidar deles como se fossem um Tamagotchi! Baseado na **PokeAPI**, o sistema permite buscar dados reais de Pokémons, interagir com eles e acompanhar sua evolução ao longo do tempo.

## 🎮 Funcionalidades

- 🔍 Buscar Pokémons reais usando a PokeAPI
- 👶 Adotar um Pokémon como mascote virtual
- 🍽️ Alimentar o mascote
- 🧸 Brincar com o mascote
- 📈 Ver o status do mascote (Fome e Felicidade)
- 📋 Listar todos os mascotes adotados
- ❌ Sair do jogo

## 🧱 Estrutura do Projeto

- `Model` – Estruturas de dados (Pokémon, TamagotchiDto, etc.)
- `View` – Interface com o usuário via console
- `Controller` – Lógica de fluxo do jogo
- `Service` – Comunicação com a API externa e mapeamento de dados

## 🔧 Tecnologias Utilizadas

- [C# .NET]
- [RestSharp] – para requisições HTTP
- [Newtonsoft.Json] – para parsing de JSON
- [AutoMapper] – para conversão de dados entre classes

