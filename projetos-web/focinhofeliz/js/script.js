// ==========================================
// Focinho Feliz - JavaScript
// ==========================================

// 1 - Confirmação antes de abrir o Google Maps
const btnMapa = document.querySelector(".btn-mapa");

if (btnMapa) {
    btnMapa.addEventListener("click", function (event) {
        const confirmar = confirm("Deseja abrir o Google Maps?");

        if (!confirmar) {
            event.preventDefault(); // Impede a abertura do link
        }
    });
}


// 2 - Mensagem ao clicar na imagem de destaque
const petDestaque = document.getElementById("pet-destaque");

if (petDestaque) {
    petDestaque.addEventListener("click", function () {
        alert("Você clicou na imagem de destaque!");
    });

    // Opcional: muda o cursor para indicar que é clicável
    petDestaque.style.cursor = "pointer";
}


// 3 - Contador de cliques nas redes sociais
const linksRedes = document.querySelectorAll("#rodape .rodape-coluna a");
let contadorCliques = 0;

linksRedes.forEach(function (link) {
    // Evita contar o botão do Google Maps
    if (link.classList.contains("btn-mapa")) return;

    link.addEventListener("click", function () {
        contadorCliques++;
        console.log(`Quantidade de cliques nas redes: ${contadorCliques}`);
    });
});


// 4 - Mensagem quando a página terminar de carregar
window.addEventListener("load", function () {
    alert("Bem-vindo ao site Focinho Feliz!");
});