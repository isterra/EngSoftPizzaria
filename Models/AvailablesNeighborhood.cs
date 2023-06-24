﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class AvailablesNeighborhood
    {
        public static List<string> Neighborhood = new List<string> {
            "Vila Pinho",
    "Esplanada",
    "Nazaré",
    "Cruzeiro",
    "Vale do Jatobá",
    "Vila Barragem Santa Lúcia",
    "Providência",
    "Flávio Marques Lisboa",
    "Novo Glória",
    "Guarani",
    "Letícia",
    "Maria Helena",
    "Coqueiros",
    "Coração Eucarístico",
    "Palmeiras(ZS)",
    "Palmeiras(ZO)",
    "Itaipu",
    "Candelária",
    "Calafate",
    "São Tomáz",
    "Alto Caiçaras",
    "Santo André",
    "Santa Lúcia",
    "Vila Clóris",
    "Santa Maria",
    "Ventosa",
    "Brasil Industrial",
    "Jardim São José",
    "São Marcos",
    "Santa Rosa",
    "Heliópolis",
    "Apolônia",
    "Marçola",
    "Minaslândia",
    "Bonsucesso(ZS)",
    "Bonsucesso(ZO)",
    "Paquetá",
    "Luxemburgo",
    "Casa Branca",
    "São Pedro",
    "Grajaú",
    "Nossa Senhora da Conceição",
    "Paulo VI",
    "Barro Preto",
    "Teixeira Dias",
    "Miramar",
    "Santa Rita de Cássia",
    "Califórnia",
    "Nova Granada(ZS)",
    "Nova Granada(ZO)",
    "Lagoinha Leblon",
    "Horto Florestal",
    "Jardim Montanhês",
    "Juliana",
    "São Salvador",
    "Coração de Jesus",
    "Silveira",
    "Olaria",
    "Pompéia",
    "Vila Cemig",
    "Nova Cintra",
    "Castanheira",
    "Palmares(ZL)",
    "Palmares(ZN)",
    "Cinquentenário",
    "Bandeirantes",
    "Santa Helena",
    "Santa Branca",
    "Vila Maria",
    "Alto Barroca",
    "Vista Alegre",
    "Vista do Sol",
    "Aparecida Sétima Seção",
    "Saudade",
    "Lajedo",
    "Graça",
    "São Luíz",
    "Estrela do Oriente",
    "Nova Cachoeirinha",
    "Ipê",
    "Urca",
    "Bairro Novo das Indústrias",
    "Boa Viagem",
    "Estoril",
    "Nova Floresta",
    "Monsenhor Messias",
    "Liberdade",
    "Madre Gertrudes",
    "Pedreira Prado Lopes",
    "Bonfim(ZN)",
    "Bonfim(HC)",
    "Nova Esperança",
    "Conjunto Minascaixa",
    "São Francisco",
    "Solar do Barreiro",
    "Nossa Senhora da Aparecida",
    "Trevo",
    "Confisco",
    "Dom Cabral",
    "Mineirão",
    "Dom Silvério",
    "Fernão Dias",
    "Ouro Minas",
    "Beira-Linha",
    "Santana do Cafezal",
    "Jaraguá",
    "Vila Primeiro de Maio",
    "Eymard",
    "Novo São Lucas",
    "Lagoinha(ZN)",
    "Lagoinha(HC)",
    "Vera Cruz",
    "Maria Virgínia(ZL)",
    "Maria Virgínia(ZN)",
    "Carmo",
    "Oeste",
    "São Paulo",
    "Conjunto Jatobá",
    "Fazendinha",
    "São Bento",
    "Vila Novo São Lucas",
    "Leonina",
    "Bom Jesus",
    "Granja de Freitas",
    "Vila Paris",
    "Mariano de Abreu",
    "Minas Brasil",
    "Monte Azul",
    "Mangueiras",
    "Inconfidência",
    "Ermelinda",
    "Jatobá",
    "Vitória",
    "Horto",
    "Taquaril",
    "Conjunto Califórnia I",
    "Indaiá",
    "Barroca",
    "Dom Joaquim",
    "Pirajá",
    "Conjunto Paulo VI",
    "Alto dos Pinheiros",
    "Parque São José",
    "Vila Califórnia",
    "Novo Tupi",
    "Vila Independência I",
    "Conjunto Jardim Filadélfia",
    "São Lucas",
    "Vila Sumaré",
    "São Cristóvão",
    "Aarão Reis",
    "Pilar",
    "Santa Cecília",
    "Marajó",
    "Flávio de Oliveira",
    "São Jorge III",
    "Senhor dos Passos",
    "Universo",
    "Santa Rita",
    "Santa Sofia",
    "Conjunto Capitão Eduardo",
    "Campo Alegre",
    "Vila Jardim Alvorada",
    "São Jorge II",
    "Conjunto Celso Machado",
    "Venda Nova",
    "Pongelupe",
    "Zilah Spósito",
    "Canaã",
    "São Gonçalo",
    "Jonas Veiga",
    "Acaiaca",
    "Vila São João Batista",
    "Primeiro de Maio",
    "Novo Santa Cecília",
    "Etelvina Carneiro",
    "Parque São Pedro",
    "Santa Margarida",
    "Cenáculo",
    "Vila Nova Cachoeirinha I",
    "Belmonte",
    "Penha",
    "Alpes",
    "Petrópolis",
    "Mariquinhas",
    "Esperança",
    "Ernesto do Nascimento",
    "Vila Santa Mônica",
    "Vila Aeroporto",
    "Granja Werneck(ZN)",
    "Granja Werneck(ZL)",
    "Braúnas",
    "Águas Claras",
    "Alta Tensão I",
    "Frei Leopoldo",
    "Universitário",
    "Suzana",
    "Mangabeiras",
    "Vila Madre Gertrudes I",
    "Vila Mangueiras",
    "Barão Homem de Melo I",
    "Vila São Paulo",
    "Túnel de Ibirité",
    "Imbaúbas",
    "Ademar Maldonado",
    "Itatiaia",
    "João Paulo II",
    "Comiteco",
    "Conjunto Califórnia II",
    "Jardinópolis",
    "São Jorge I",
    "Vila Ecológica",
    "Vila Jardim São José",
    "Vila Piratininga",
    "São João",
    "Biquinhas",
    "Tiradentes",
    "Pousada Santo Antônio",
    "Vila Nossa Senhora Aparecida",
    "Vila Antena",
    "São Benedito",
    "Estrela",
    "Vila Átila de Paiva",
    "Olhos d'Água",
    "Vila Coqueiral",
    "Cidade Jardim",
    "Vila Trinta e Um de Março",
    "São José",
    "Solimões",
    "Bernadete",
    "Xodó-Marize",
    "Vila da Luz",
    "Jardim Atlântico",
    "Vila Formosa",
    "Vila Nova Gameleira II",
    "Vila Santa Rosa",
    "Engenho Nogueira",
    "Vila Copacabana",
    "São Francisco das Chagas",
    "Vila Oeste",
    "Aeroporto",
    "Beija Flor",
    "Capitão Eduardo",
    "Marieta I",
    "Átila de Paiva",
    "Vila São Rafael",
    "Vitória da Conquista",
    "Acaba Mundo",
    "Conjunto Santa Maria",
    "Jardim do Vale",
    "Monte São José",
    "Álvaro Camargos",
    "Sport Club",
    "Bairro das Indústrias II",
    "Conjunto Bonsucesso",
    "Vila Dias",
    "Vila Esplanada",
    "Vila Independência II",
    "Vila de Sá",
    "Garças",
    "Vila Boa Vista",
    "Delta",
    "Corumbiara",
    "Madri",
    "Pantanal",
    "Conjunto Floramar",
    "Vila Pilar",
    "Vila Olhos d'Água",
    "Marilândia",
    "Virgínia",
    "Vila Minaslândia",
    "Vila Nova Gameleira I",
    "Vila dos Anjos",
    "Ambrosina",
    "Andiroba",
    "Marmiteiros",
    "Guaratã",
    "Vila União",
    "Vila Mantiqueira",
    "Conjunto Novo Dom Bosco",
    "Vila Nova Paraíso",
    "Vila Paquetá",
    "Vila Inestan",
    "Vila São Gabriel Jacuí",
    "Vila Nova Cachoeirinha IV",
    "Vila Real II",
    "Vila Nossa Senhora do Rosário",
    "Vila Santo Antônio Barroquinha",
    "Vila Madre Gertrudes II",
    "Bela Vitória",
    "Vila Maloca",
    "Conjunto Lagoa",
    "Vila Suzana I",
    "Distrito Industrial do Jatobá",
    "Pirineus",
    "Vila Aeroporto Jaraguá",
    "Vila Nova",
    "Vila Ouro Minas",
    "Três Marias",
    "Vila Nova dos Milionários",
    "Vila Itatiaia",
    "Vila Minas Caixa",
    "Bairro Industrial",
    "Vila Atlântico",
    "Vila Mantiqueira II",
    "Vila Petrolina",
    "Santa Fé",
    "Vila Dom Cabral",
    "Vila Itaú",
    "Vila Santo Antônio",
    "Vila das Flores",
    "Vila Nova dos Comerciários",
    "Vila do Sol",
    "Vila Nova Vista",
    "Vila Ipanema",
    "Vila Nova Pampulha",
    "Vila Nova Esperança",
    "Vila Santo Antônio Bela Vista",
    "Vila Vista Alegre",
    "Vila Nova Bonsucesso",
    "Vila Capitão Eduardo",
    "Vila Primeiro de Janeiro",
    "Vila Suzana II",
    "Vila Solar",
    "Vila Santa Rosa IV",
    "Vila Paquetá I",
    "Vila Santa Rosa III",
    "Vila Santa Rosa I",
    "Vila Santa Rosa II",
    "Vila São Gabriel",
    "Vila Belo Horizonte",
    "Vila Vitoriosa",
    "Vila Vitoriosa II",
    "Vila Madre Gertrudes III",
    "Vila Madre Gertrudes IV",
    "Vila Madre Gertrudes V",
    "Vila Itatiaia II",
    "Vila Inestan II",
    "Vila Nova Cachoeirinha III",
    "Vila Nova Cachoeirinha II",
    "Vila Nova Cachoeirinha V",
    "Vila Nova Cachoeirinha VI",
    "Vila Nossa Senhora Aparecida II",
    "Vila Real I",
    "Vila Nova Esperança II",
    "Vila Madre Gertrudes VI",
    "Vila Capitão Eduardo II",
    "Vila Capitão Eduardo III",
    "Vila Oeste II",
    "Vila Mantiqueira III",
    "Vila Mantiqueira IV",
    "Vila Santa Rosa V",
    "Vila Santa Rosa VI",
    "Vila Nova dos Milionários II",
    "Vila Nova dos Milionários III",
    "Vila Nova Bonsucesso II",
    "Vila Nova Bonsucesso III",
    "Vila Belo Horizonte II",
    "Vila Belo Horizonte III",
    "Vila Vitoriosa III",
    "Vila Vitoriosa IV",
    "Vila Madre Gertrudes VII",
    "Vila Madre Gertrudes VIII",
    "Vila Madre Gertrudes IX",
    "Vila Capitão Eduardo IV",
    "Vila Capitão Eduardo V",
    "Vila Oeste III",
    "Vila Oeste IV",
    "Vila Mantiqueira V",
    "Vila Mantiqueira VI",
    "Vila Santa Rosa VII",
    "Vila Santa Rosa VIII",
    "Vila Nova dos Milionários IV",
    "Vila Nova dos Milionários V",
    "Vila Nova Bonsucesso IV",
    "Vila Nova Bonsucesso V",
    "Vila Belo Horizonte IV",
    "Vila Belo Horizonte V",
    "Vila Vitoriosa V",
    "Vila Vitoriosa VI",
    "Vila Madre Gertrudes X",
    "Vila Madre Gertrudes XI",
    "Vila Capitão Eduardo VI",
    "Vila Capitão Eduardo VII",
    "Vila Oeste V",
    "Vila Oeste VI",
    "Vila Mantiqueira VII",
    "Vila Mantiqueira VIII",
    "Vila Santa Rosa IX",
    "Vila Santa Rosa X",
    "Vila Nova dos Milionários VI",
    "Vila Nova dos Milionários VII",
    "Vila Nova Bonsucesso VI",
    "Vila Nova Bonsucesso VII",
    "Vila Belo Horizonte VI",
    "Vila Belo Horizonte VII",
    "Vila Vitoriosa VII",
    "Vila Vitoriosa VIII",
    "Vila Capitão Eduardo VIII",
    "Vila Capitão Eduardo IX",
    "Vila Oeste VII",
    "Vila Oeste VIII",
    "Vila Mantiqueira IX",
    "Vila Mantiqueira X",
    "Vila Santa Rosa XI",
    "Vila Santa Rosa XII",
    "Vila Nova dos Milionários VIII",
    "Vila Nova dos Milionários IX",
    "Vila Nova Bonsucesso VIII",
    "Vila Nova Bonsucesso IX",
    "Vila Belo Horizonte VIII",
    "Vila Belo Horizonte IX",
    "Vila Vitoriosa IX",
    "Vila Vitoriosa X",
    "Vila Capitão Eduardo X",
    "Vila Capitão Eduardo XI",
    "Vila Oeste IX",
    "Vila Oeste X",
    "Vila Mantiqueira XI",
    "Vila Mantiqueira XII",
    "Vila Santa Rosa XIII",
    "Vila Santa Rosa XIV",
    "Vila Nova dos Milionários X",
    "Vila Nova dos Milionários XI",
    "Vila Nova Bonsucesso X",
    "Vila Nova Bonsucesso XI",
    "Vila Belo Horizonte X",
    "Vila Belo Horizonte XI",
    "Vila Vitoriosa XI",
    "Vila Vitoriosa XII",
    "Vila Capitão Eduardo XII",
    "Vila Capitão Eduardo XIII",
    "Vila Oeste XI",
    "Vila Oeste XII",
    "Vila Mantiqueira XIII",
    "Vila Mantiqueira XIV",
    "Vila Santa Rosa XV",
    "Vila Santa Rosa XVI",
    "Vila Nova dos Milionários XII",
    "Vila Nova dos Milionários XIII",
    "Vila Nova Bonsucesso XII",
    "Vila Nova Bonsucesso XIII",
    "Vila Belo Horizonte XII",
    "Vila Belo Horizonte XIII",
    "Vila Vitoriosa XIII",
    "Vila Vitoriosa XIV",
    "Vila Capitão Eduardo XIV",
    "Vila Capitão Eduardo XV",
    "Vila Oeste XIII",
    "Vila Oeste XIV",
    "Vila Mantiqueira XV",
    "Vila Mantiqueira XVI",
    "Vila Santa Rosa XVII",
    "Vila Santa Rosa XVIII",
    "Vila Nova dos Milionários XIV",
    "Vila Nova dos Milionários XV",
    "Vila Nova Bonsucesso XIV",
    "Vila Nova Bonsucesso XV",
    "Vila Belo Horizonte XIV",
    "Vila Belo Horizonte XV",
    "Vila Vitoriosa XV",
    "Vila Vitoriosa XVI",
    "Vila Capitão Eduardo XVI",
    "Vila Capitão Eduardo XVII",
    "Vila Oeste XV",
    "Vila Oeste XVI",
    "Vila Mantiqueira XVII",
    "Vila Mantiqueira XVIII",
    "Vila Santa Rosa XIX",
    "Vila Santa Rosa XX",
    "Vila Nova dos Milionários XVI",
    "Vila Nova dos Milionários XVII",
    "Vila Nova Bonsucesso XVI",
    "Vila Nova Bonsucesso XVII",
    "Vila Belo Horizonte XVI",
    "Vila Belo Horizonte XVII",
    "Vila Vitoriosa XVII",
    "Vila Vitoriosa XVIII",
    "Vila Capitão Eduardo XVIII",
    "Vila Capitão Eduardo XIX",
    "Vila Oeste XVII",
    "Vila Oeste XVIII",
    "Vila Mantiqueira XIX",
    "Vila Mantiqueira XX",
    "Vila Santa Rosa XXI",
    "Vila Santa Rosa XXII",
    "Vila Nova dos Milionários XIX",
    "Vila Nova dos Milionários XX",
    "Vila Nova Bonsucesso XVIII",
    "Vila Nova Bonsucesso XIX",
    "Vila Belo Horizonte XVIII",
    "Vila Belo Horizonte XIX",
    "Vila Vitoriosa XIX",
    "Vila Vitoriosa XX",
    "Vila Capitão Eduardo XX",
    "Vila Capitão Eduardo XXI",
    "Vila Oeste XIX",
    "Vila Oeste XX",
    "Vila Mantiqueira XXI",
    "Vila Mantiqueira XXII",
    "Vila Santa Rosa XXIII",
    "Vila Santa Rosa XXIV",
    "Vila Nova dos Milionários XXI",
    "Vila Nova dos Milionários XXII",
    "Vila Nova Bonsucesso XX",
    "Vila Nova Bonsucesso XXI",
    "Vila Belo Horizonte XX",
    "Vila Belo Horizonte XXI",
    "Vila Vitoriosa XXI",
    "Vila Vitoriosa XXII",
    "Vila Capitão Eduardo XXII",
    "Vila Capitão Eduardo XXIII",
    "Vila Oeste XXI",
    "Vila Oeste XXII",
    "Vila Mantiqueira XXIII",
    "Vila Mantiqueira XXIV",
    "Vila Santa Rosa XXV",
    "Vila Santa Rosa XXVI",
    "Vila Nova dos Milionários XXIII",
    "Vila Nova dos Milionários XXIV",
    "Vila Nova Bonsucesso XXII",
    "Vila Nova Bonsucesso XXIII",
    "Vila Belo Horizonte XXII",
    "Vila Belo Horizonte XXIII",
    "Vila Vitoriosa XXIII",
    "Vila Vitoriosa XXIV",
    "Vila Capitão Eduardo XXIV",
    "Vila Capitão Eduardo XXV",
    "Vila Oeste XXIII",
    "Vila Oeste XXIV",
    "Vila Mantiqueira XXV",
    "Vila Mantiqueira XXVI",
    "Vila Santa Rosa XXVII",
    "Vila Santa Rosa XXVIII",
    "Vila Nova dos Milionários XXV",
    "Vila Nova dos Milionários XXVI",
    "Vila Nova Bonsucesso XXIV",
    "Vila Nova Bonsucesso XXV",
    "Vila Belo Horizonte XXIV",
    "Vila Belo Horizonte XXV",
    "Vila Vitoriosa XXV",
    "Vila Vitoriosa XXVI",
    "Vila Capitão Eduardo XXVI",
    "Vila Capitão Eduardo XXVII",
    "Vila Oeste XXV",
    "Vila Oeste XXVI",
    "Vila Mantiqueira XXVII",
    "Vila Mantiqueira XXVIII",
    "Vila Santa Rosa XXIX",
    "Vila Santa Rosa XXX",
    "Vila Nova dos Milionários XXVII",
    "Vila Nova dos Milionários XXVIII",
    "Vila Nova Bonsucesso XXVI",
    "Vila Nova Bonsucesso XXVII",
    "Vila Belo Horizonte XXVI",
    "Vila Belo Horizonte XXVII",
    "Vila Vitoriosa XXVII",
    "Vila Vitoriosa XXVIII",
    "Vila Capitão Eduardo XXVIII",
    "Vila Capitão Eduardo XXIX",
    "Vila Oeste XXVII",
    "Vila Oeste XXVIII",
    "Vila Mantiqueira XXIX",
    "Vila Mantiqueira XXX",
    "Vila Santa Rosa XXXI",
    "Vila Santa Rosa XXXII",
    "Vila Nova dos Milionários XXX",
    "Vila Nova dos Milionários XXXI",
    "Vila Nova Bonsucesso XXVIII",
    "Vila Nova Bonsucesso XXIX",
    "Vila Belo Horizonte XXVIII",
    "Vila Belo Horizonte XXIX",
    "Vila Vitoriosa XXIX",
    "Vila Vitoriosa XXX",
    "Vila Capitão Eduardo XXX",
    "Vila Capitão Eduardo XXXI",
    "Vila Oeste XXIX",
    "Vila Oeste XXX",
    "Vila Mantiqueira XXXI",
    "Vila Mantiqueira XXXII",
    "Vila Santa Rosa XXXIII",
    "Vila Santa Rosa XXXIV",
    "Vila Nova dos Milionários XXXII",
    "Vila Nova dos Milionários XXXIII",
    "Vila Nova Bonsucesso XXX",
    "Vila Nova Bonsucesso XXXI",
    "Vila Belo Horizonte XXX",
    "Vila Belo Horizonte XXXI",
    "Vila Vitoriosa XXXI",
    "Vila Vitoriosa XXXII",
    "Vila Capitão Eduardo XXXII",
    "Vila Capitão Eduardo XXXIII",
    "Vila Oeste XXXI",
    "Vila Oeste XXXII",
    "Vila Mantiqueira XXXIII",
    "Vila Mantiqueira XXXIV",
    "Vila Santa Rosa XXXV",
    "Vila Santa Rosa XXXVI",
    "Vila Nova dos Milionários XXXIV",
    "Vila Nova dos Milionários XXXV",
    "Vila Nova Bonsucesso XXXII",
    "Vila Nova Bonsucesso XXXIII",
    "Vila Belo Horizonte XXXII",
    "Vila Belo Horizonte XXXIII",
    "Vila Vitoriosa XXXIII",
    "Vila Vitoriosa XXXIV",
    "Vila Capitão Eduardo XXXIV",
    "Vila Capitão Eduardo XXXV",
    "Vila Oeste XXXIII",
    "Vila Oeste XXXIV",
    "Vila Mantiqueira XXXV",
    "Vila Mantiqueira XXXVI",
    "Vila Santa Rosa XXXVII",
    "Vila Santa Rosa XXXVIII",
    "Vila Nova dos Milionários XXXVI",
    "Vila Nova dos Milionários XXXVII",
    "Vila Nova Bonsucesso XXXIV",
    "Vila Nova Bonsucesso XXXV",
    "Vila Belo Horizonte XXXIV",
    "Vila Belo Horizonte XXXV",
    "Vila Vitoriosa XXXV",
    "Vila Vitoriosa XXXVI",
    "Vila Capitão Eduardo XXXVI",
    "Vila Capitão Eduardo XXXVII",
    "Vila Oeste XXXV",
    "Vila Oeste XXXVI",
    "Vila Mantiqueira XXXVII",
    "Vila Mantiqueira XXXVIII",
    "Vila Santa Rosa XXXIX",
    "Vila Santa Rosa XL",
    "Vila Nova dos Milionários XXXVIII",
    "Vila Nova dos Milionários XXXIX",
    "Vila Nova Bonsucesso XXXVI",
    "Vila Nova Bonsucesso XXXVII",
    "Vila Belo Horizonte XXXVI",
    "Vila Belo Horizonte XXXVII",
    "Vila Vitoriosa XXXVII",
    "Vila Vitoriosa XXXVIII",
    "Vila Capitão Eduardo XXXVIII",
    "Vila Capitão Eduardo XXXIX",
    "Vila Oeste XXXVII",
    "Vila Oeste XXXVIII",
    "Vila Mantiqueira XXXIX",
    "Vila Mantiqueira XL",
    "Vila Santa Rosa XLI",
    "Vila Santa Rosa XLII",
    "Vila Nova dos Milionários XL",
    "Vila Nova dos Milionários XLI",
    "Vila Nova Bonsucesso XXXVIII",
    "Vila Nova Bonsucesso XXXIX",
    "Vila Belo Horizonte XXXVIII",
    "Vila Belo Horizonte XXXIX",
    "Vila Vitoriosa XXXIX",
    "Vila Vitoriosa XL",
    "Vila Capitão Eduardo XL",
    "Vila Capitão Eduardo XLI",
    "Vila Oeste XXXIX",
    "Vila Oeste XL",
    "Vila Mantiqueira XLI",
    "Vila Mantiqueira XLII",
    "Vila Santa Rosa XLIII",
    "Vila Santa Rosa XLIV",
    "Vila Nova dos Milionários XLII",
    "Vila Nova dos Milionários XLIII",
    "Vila Nova Bonsucesso XL",
    "Vila Nova Bonsucesso XLI",
    "Vila Belo Horizonte XL",
    "Vila Belo Horizonte XLI",
    "Vila Vitoriosa XLI",
    "Vila Vitoriosa XLII",
    "Vila Capitão Eduardo XLII",
    "Vila Capitão Eduardo XLIII",
    "Vila Oeste XLI",
    "Vila Oeste XLII",
    "Vila Mantiqueira XLIII",
    "Vila Mantiqueira XLIV",
    "Vila Santa Rosa XLV",
    "Vila Santa Rosa XLVI",
    "Buritis",
    "Padre Eustáquio",
    "Lindéia",
    "Santa Mônica",
    "Céu Azul",
    "Santa Cruz(ZN)",
    "Santa Cruz(ZL)",
    "Santo Antônio",
    "Alto Vera Cruz",
    "Jardim dos Comerciários",
    "Piratininga",
    "Mantiqueira",
    "Serra",
    "Sion",
    "Lourdes",
    "Santa Amélia",
    "Cabana do Pai Tomás",
    "Santa Efigênia(ZL)",
    "Santa Efigênia(HC)",
    "Pindorama",
    "Boa Vista",
    "Gutierrez",
    "Ouro Preto",
    "Castelo",
    "Planalto",
    "São João Batista",
    "Centro",
    "Goiânia",
    "Jaqueline",
    "Ribeiro de Abreu",
    "Santa Terezinha",
    "Santa Tereza",
    "Jardim Felicidade",
    "Cidade Nova",
    "Carlos Prates(ZO)",
    "Carlos Prates(HC)",
    "Havaí",
    "Nova Suissa",
    "Conjunto Taquaril",
    "União",
    "Salgado Filho",
    "Araguaia",
    "Glória",
    "Serra Verde",
    "São Geraldo",
    "Prado",
    "São Gabriel",
    "Tupi B",
    "Paraíso",
    "Copacabana",
    "Caiçaras",
    "Camargos",
    "Rio Branco",
    "Anchieta",
    "Ipiranga",
    "Milionários",
    "Betânia",
    "Diamante",
    "Floresta(HC)",
    "Floresta(ZL)",
    "Savassi",
    "Jardim Guanabara",
    "Vila Vista Alegre",
    "Tirol",
    "Jardim América(ZO)",
    "Jardim América(ZS)",
    "Caiçara-Adelaide",
    "Concórdia",
    "Tupi A",
    "Minascaixa",
    "Cardoso",
    "Colégio Batista(ZL)",
    "Colégio Batista(HC)",
    "Barreiro",
    "Europa",
    "Serrano",
    "Jardim Alvorada(ZO)",
    "Jardim Alvorada(ZN)",
    "Santo Agostinho",
    "Aparecida",
    "Floramar",
    "Dom Bosco",
    "João Pinheiro",
    "Nossa Senhora de Fátima",
    "Jardim Vitória",
    "Alípio de Melo",
    "Nova Gameleira",
    "Itapoã",
    "Jardim Leblon",
    "Cachoeirinha",
    "Bairro das Indústrias I",
    "Santa Inês",
    "Lagoa",
    "São Bernardo",
    "Renascença",
    "Dona Clara",
    "Funcionários",
    "Belvedere",
    "Maria Goretti",
    "Nova Vista",
    "Independência",
    "Novo Aarão Reis",
    "Manacás" };
    }
}