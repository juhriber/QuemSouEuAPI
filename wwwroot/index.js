const preencherDados = async () => {
    const endpoint = '/QuemSouEu';
    const response = await fetch(endpoint);
    const result = await response.json();

    const paragrafo = document.getElementById('meus-dados');

    const mensagem = `Olá, eu sou ${result.nome} ${result.sobrenome}, visite meu GitHub <a href="https://github.com/${result.usuarioGitHub}">@${result.usuarioGitHub}</a>.`;

    paragrafo.innerHTML = mensagem;
};

document.addEventListener('DOMContentLoaded', preencherDados);