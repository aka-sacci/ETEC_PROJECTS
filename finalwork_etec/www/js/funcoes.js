var $$ = Dom7;
var searchbar = app.searchbar.create({
    el: '.searchbar',
    searchContainer: '.list',
    searchIn: '.item-title',
    on: {
        search(sb, query, previousQuery) {
            console.log(query, previousQuery);
        }
    }
});

$("#telefone, #celular, #tel").mask("(00) 00000-0000");



function enviamsg(){
         var xmlhttp = new XMLHttpRequest();

    var ong = localStorage.getItem("Ong");
    var tel = localStorage.getItem("Telefone");
    console.log(ong+", "+tel);
    var url = "http://localhost/www/php/insertmsg.php/?ong=" + ong + "&tel=" + tel+"&msg='"+document.getElementById('mensagem').value+"';";
        xmlhttp.open("GET", url, true);
        xmlhttp.send();
    
    
    
}

function chat(ong){
    
    app.router.navigate('/chat/');
    
    app.preloader.show('blue');
    var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/conversas.php?ong="+ong+"?user="+localStorage.getItem("Telefone");+"";
    localStorage.setItem("Ong", ong);


    xmlhttp.onreadystatechange = function () {

    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

   xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        try{
        
    var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


       for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            
            if(dados[i].tb08_user == localStorage.getItem){
                
                conteudo += "<div class='messages'><div class='message-name'></div><div class='message-bubble'>Você: <div class='message-text'> "+dados[i].tb05_mensagem+" </div></div></div>";  
                
            }else{
        conteudo += "<div class='messages'><div class='message-name'></div><div class='message-bubble'>"+dados[i].tb08_nome+" <div class='message-text'> "+dados[i].tb05_mensagem+" </div></div></div>";    
            
            
        }}
        

       
            app.preloader.hide();
        }catch{
            
                        app.preloader.hide();
                        console.log("nada");


         
            
    }
    }
    
    
    
}


function liga(nro){
    app.dialog.alert(nro);      
    
}

function mapa(){
    
    
}

function campanha(id){
    
   app.preloader.show('blue');
    app.router.navigate('/campanha/');
     var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/campanha.php?id="+id+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            var datainicioinvertida = dados[i].tb09_datainicio;
            var mesinicio = datainicioinvertida.substring(5, 7);
            var diainicio = datainicioinvertida.substr(8);
            var datainiciocerta = diainicio+"/"+mesinicio;
            
            var datafiminvertida = dados[i].tb09_datafim;
            var mesfim = datafiminvertida.substring(5, 7);
            var diafim = datafiminvertida.substr(8);
            var datafimcerta = diafim+"/"+mesfim;
            
             var status = "";
            
            if(dados[i].tb09_status == "1"){
                
                status = "Ativa.";
            }else{
                
                status = "Não ativa.";
            }
            
            conteudo += "<h4 style='text-align: center !important; color: white; font-weight: bolder !important;'>"+dados[i].tb09_nome+"</h4>";
            conteudo += "<p style='color: aliceblue; padding: 5% !important' id='responsaveis'></p>";
            conteudo += "<p style='color: white; padding: 5% !important'>"+dados[i].tb09_descricao+"</p>";
            conteudo += "<p style='color: white; padding: 5% !important'><b>Objetivo final:</b> "+dados[i].tb09_objetivo+"</p>";
            conteudo += "<p style='color: white; padding: 5% !important'> <b>Período:</b> "+datainiciocerta+" até "+datafimcerta+". <b>Status:</b> "+status+"</p>";
            conteudo += "<p style='color: white; padding: 5% !important' id='tipocampanha'></p>";
            conteudo += "<div class='row aa' style='margin-left: 10%; margin-right: 10%;'>";
            conteudo += "</div>";
     
   
            responsaveis(id);
            tipocampanha(id);

        }
        
        
        document.getElementById("c3").innerHTML = conteudo;
        document.getElementById('left').innerHTML = "<a href='#' class='back link'><i class='icon icon-back'></i></a>";
        

    }
    
    
}

function tipocampanha(id){
    
    
    var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/tipocampanha.php?id="+id+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            
            if(dados.length == i+1){
                
                conteudo += dados[i].tb03_tipo+".";
                
            }else{
            
            conteudo += dados[i].tb03_tipo+", ";
            
            }
            
        }
        
        document.getElementById("tipocampanha").innerHTML = "<b>Aceita: </b>"+conteudo;
        

    }
    
    
    app.preloader.hide;
}

function responsaveis(id){
    
    
    var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/responsaveis.php?id="+id+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            
            if(dados.length == 1){
                
                conteudo += "Por <a onclick='carregainfo("+dados[i].tb10_ong+")'>"+dados[i].tb01_nome+"</a>. ";
                
            } else{
            
            if(dados.length == i+1){
                
                conteudo += "<a onclick='carregainfo("+dados[i].tb10_ong+")'>"+dados[i].tb01_nome+"</a>. ";
                
            }else{
            if(i == 0){
                conteudo += "Por <a onclick='carregainfo("+dados[i].tb10_ong+")'>"+dados[i].tb01_nome+"</a>, ";
                
            }else{
                
            conteudo += "<a onclick='carregainfo("+dados[i].tb10_ong+")'>"+dados[i].tb01_nome+"</a>, ";
            }
            }

            }
            
        }
        
        document.getElementById("responsaveis").innerHTML = conteudo;
        app.preloader.hide();
        

    }
    
    
    
}

function carregacampanhas(ong) {
app.preloader.show('blue');
 var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selectcampanhas.php?ong="+ong+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        try{
        var dados = JSON.parse(response);
        document.getElementById('conteudocampanha').innerHTML = "<h5 style='text-align: center !important; color: white; font-weight: bolder !important;'>CAMPANHAS:</h5><br><div class='list'><ul id='conteudoacordions'></ul></div>";
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
          var status = "";
            
            if(dados[i].tb09_status == "1"){
                
                status = "Campanha ativa.";
            }else{
                
                status = "Campanha não ativa.";
            }
            
            conteudo += "<li class='accordion-item'><a href='#' class='item-content item-link'>";
            conteudo += "<div class='item-inner'>";
            conteudo += "<div class='item-title' style='color: white; font-weight: bolder !important;'>"+dados[i].tb09_nome+"</div>";
            conteudo += "</div></a>";
            conteudo += "<div class='accordion-item-content'>";
            conteudo += "<div class='block'>";
            conteudo += "<p style='color: white;'>"+dados[i].tb09_objetivo+". "+status+" <a onclick='campanha("+dados[i].tb09_id+")'>Saber mais.</a></p>";
            conteudo += " </div>";
            conteudo += "</div>";
            conteudo += "</li>";
            

        }
        
        document.getElementById('conteudoacordions').innerHTML = conteudo;
        
        app.preloader.hide();

    }catch{
        app.preloader.hide();
        
    }
        
    }
        
        
}

function login() {
    var telefoneverdadeiro = $('#telefone').cleanVal();



    if (document.getElementById("senha").value == "" || telefoneverdadeiro == "") {

        app.dialog.alert("Preencha todos os campos!", "Aviso:");

    } else {
        app.preloader.show('blue');
        var senha = document.getElementById("senha").value;
        $.post("php/login.php", { username: telefoneverdadeiro, password: senha })
        .done(function( data ){
            
            
            if(data != " n"){

                var nome = data.substring(11);
                
                
                localStorage.setItem("Telefone", telefoneverdadeiro);
                localStorage.setItem("Nome", nome);
                localStorage.setItem("TelefoneMask", document.getElementById("telefone").value);
                localStorage.setItem("Senha", document.getElementById("senha").value);
                app.router.navigate('/ongs/');
                app.preloader.hide();
                app.panel.enableSwipe();
                app.preloader.hide();
            }else{
                
                app.dialog.alert("Usuário não encontrado!", "Aviso:");
                
                app.preloader.hide();
                
                document.getElementById("senha").value = "";
            }
        });
        //faz login, se houver conta:


        
    }
}

function login1() {
    var telefoneverdadeiro = $('#telefone').cleanVal();



    if (document.getElementById("senha").value == "" || telefoneverdadeiro == "") {

        app.dialog.alert("Preencha todos os campos!", "Aviso:");

    } else {
        app.preloader.show('blue');
        var senha = document.getElementById("senha").value;
       
            
            
        var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/login1.php?login="+telefoneverdadeiro+"&senha="+senha+"";
    



    xmlhttp.onreadystatechange = function () {

    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

   xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        try{
        
    var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";
            var c2 = "";


       for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            
            
            localStorage.setItem("Telefone", telefoneverdadeiro);
                localStorage.setItem("Nome", dados[i].tb08_nome);
                localStorage.setItem("TelefoneMask", document.getElementById("telefone").value);
                localStorage.setItem("Senha", document.getElementById("senha").value);
                app.router.navigate('/ongs/');
                app.preloader.hide();
                app.panel.enableSwipe();
                app.preloader.hide();
            
            
            
        }
        
                   
            
        }catch{
            
         app.dialog.alert("Usuário não encontrado!", "Aviso:");
                
                app.preloader.hide();
                
                document.getElementById("senha").value = "";

            app.preloader.hide();
    }
    }
    
            
        
        

                
                
                
                
           
                
                
          
        
        //faz login, se houver conta:


        
    }
}


function loginautomatico() {

    var online = navigator.onLine;


    if (online) {

        if (localStorage.getItem("Telefone")) {
            app.preloader.show('blue');
            $.post("php/login.php", { username: localStorage.getItem("Telefone"), password: localStorage.getItem("Senha") })
        .done(function( data ){
            
            
            if(data != " n"){
                var nome = data.substring(11);
                localStorage.setItem("Nome", nome);
                app.router.navigate('/ongs/');
                app.preloader.hide();
                app.panel.enableSwipe();
                app.preloader.hide();
            }else{
                
                app.dialog.alert("O usuário salvo para o login automático foi excluído!", "Aviso:");             
                
                app.panel.disableSwipe();
                localStorage.clear();
                document.getElementById("senha").value = "";
                app.preloader.hide();
            }
        });
            //faz login
            
            
            
            document.getElementById("telefone").value = localStorage.getItem("TelefoneMask");

            //$("#telefone, #celular").mask("(00) 00000-0000");

            
            

        } else {


            app.panel.disableSwipe();

        }

    } else {
        document.getElementById("icontent").innerHTML = "<br><br><br><br><br><br><h3 style='color: white; text-align:center;'>Conexão não identificada!</h3><p style='color: white; text-align:center;'>Ligue seu 3G ou sua WiFi para se reconectar</p><br>";
        app.panel.disableSwipe();
        var interval = setInterval(function () {
            var online = navigator.onLine;
            if (online) {



                clearInterval(interval);
                app.preloader.show('blue');
                location.reload();


            } else {


            }

        }, 1000);


    }

}

function chamafot(ong, nome) {
    app.router.navigate('/foto/');
    
    app.preloader.show('blue');
    var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selectimgs.php?ong="+ong+"";
    



    xmlhttp.onreadystatechange = function () {

    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

   xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        try{
        
    var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";
            var c2 = "";


       for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            
            
            conteudo += " <div class='col'>";
            conteudo += "<div class='card card-outline'>";
            conteudo += "<div class='card-content card-content-padding'><center><img src='imgs/"+dados[i].tb12_seq+".png'></center></div>";
            conteudo += "<div class='card-footer' id='card'>"+dados[i].tb12_descricao+", "+dados[i].tb12_data_upload+"</div>";
            conteudo += "</div></div>";
            c2 = "<div class='navbar-inner'><div class='left'><a href='#' class='back link'><i class='icon icon-back'></i></a></div><img src='imgs/"+ong+".png'>   <p class='text-align-center'' id='nome_ong'>Fotos</p><div class='right'><a href='#' class='panel-open' style='padding-right: 5% !important;'><i class='f7-icons'>bars</i> </a></div></div>";
            
            
        }
        
                   
            console.log("passo aq");
        document.getElementById('content4').innerHTML = conteudo;
        document.getElementById('conteudoft').innerHTML = c2;
            app.preloader.hide();
        }catch{
            
          document.getElementById('content4').innerHTML = "<center><font color='white'><b><h3>IMAGENS NÃO ENCONTRADAS</h3></b></font><img src='imgs/alert-icon.png' width='200' ><br/><font color='white'><b>A ONG não tem imagens para exibir</b></font></center>";  
            document.getElementById('conteudoft').innerHTML = "<div class='navbar-inner'><div class='left'><a href='#' class='back link'><i class='icon icon-back'></i></a></div><img src='imgs/"+ong+".png'>   <p class='text-align-center'' id='nome_ong'>Fotos</p><div class='right'><a href='#' class='panel-open' style='padding-right: 5% !important;'><i class='f7-icons'>bars</i> </a></div></div>";

            app.preloader.hide();
    }
    }
    
}


function chamapag2() {
    app.router.navigate('/geo/');

}

function chamapag3() {
    app.router.navigate('/fale/');

}

function chamachat() {
    app.router.navigate('/chat/');
    

}

function chamapag4() {
    app.router.navigate('/cadastro/');

}


function carregainfo(ong){
    
    
    
    
    app.router.navigate('/infong/');
    app.preloader.show('blue');
    var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selectonginfo.php?ong="+ong+"";
    



    xmlhttp.onreadystatechange = function () {

    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

   xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
    var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


       for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   

            var cnpj = dados[i].tb01_cnpj;
            var p1 = cnpj.substring(0, 2);
            var p2 = cnpj.substring(2, 5);
            var p3 = cnpj.substring(5, 8);
            var p4 = cnpj.substring(8, 12);
            var p5 = cnpj.substring(12, 14);
            var charcnpj = p1+"."+p2+"."+p3+"/"+p4+"-"+p5;
            var numero = dados[i].tb01_telefone;
            var ddd = numero.substring(0, 2);
            var part1;
            var part2;
            
                if(numero.length == 11){
                            
               part1 = numero.substring(2, 7);
               part2 = numero.substring(7, 11);
                
                    }else{
                
                part1 = numero.substring(2, 6);
                part2 = numero.substring(6, 10);
                    }
            
            
            conteudo += "<h4 style='text-align: center !important; color: white; font-weight: bolder !important;'>"+dados[i].tb01_nome+"</h4><br>";
            conteudo += "<img src='imgs/"+dados[i].tb01_cnpj+".png' style='margin-left: 35%'>";
            conteudo += "<div style='padding: 5%'>";
            conteudo += "<p style='text-align: justify !important; color: white;'>"+dados[i].tb01_descricao+"</p>";
            conteudo += "<p style='color: white;' id='urgencias'></p>";
            conteudo += "<p style='color: white;' id='necessidades'></p>";
            conteudo += "<br>";
            conteudo += "<h5 style='text-align: center !important; color: white; font-weight: bolder !important;'>INFORMAÇÕES:</h5><br>";
            conteudo += "<div class='list'>";
            conteudo += "<p style='color: white;'>CNPJ: <b>"+charcnpj+"</b></p>";
            conteudo += "<ul>";
            conteudo += "<li class='swipeout'>";
            conteudo += "<div class='item-content swipeout-content'>";
            conteudo += "<div class='item-inner'>";
            conteudo += "<div class='item-title'><p style='color: white;'>Telefone: <b>("+ddd+") "+part1+"-"+part2+"</b></p></div>";
            conteudo += "</div>";
            conteudo += "</div>";
            conteudo += "<div class='swipeout-actions-left'>";
            conteudo += "<a href='#' class='color-green alert-reply' onclick='liga("+numero+")'>Ligar</a>";
            conteudo += "</div>";
            conteudo += "</li>";
            conteudo += "</ul>";
            conteudo += "<ul>";
            conteudo += "<li class='swipeout'>";
            conteudo += "<div class='item-content swipeout-content'>";
            conteudo += "<div class='item-inner'>";
            conteudo += "<div class='item-title'><p style='color: white;'> <p style='color: white;'>Endereço: <b>"+dados[i].tb01_endereco+", "+dados[i].tb01_bairro+"</b></p></div>";
            conteudo += "</div>";
            conteudo += "</div>";
            conteudo += "<div class='swipeout-actions-left'>";
            conteudo += "<a href='#' class='color-green alert-reply' onclick='mapa()'>Rota</a>";
            conteudo += "</div>";
            conteudo += "</li>";
            conteudo += "</ul><br>";
            conteudo += "";
            conteudo += "<button class='col button button-small button-round button-fill' onclick='chamafot("+dados[i].tb01_cnpj+")'>Fotos</button>";
            conteudo += "</div> </div>";
            conteudo += "</div><div id='conteudocampanha'></div>";
            carreganecessidade2(cnpj);
            carregaurgencia2(cnpj);
            carregacampanhas(cnpj);
            
            
            
        }
        
       
        document.getElementById('c2').innerHTML = conteudo;

    }
    app.preloader.hide();
    
}

function cadastrar() {

    var telefoneverdadeiro = $('#telefone').cleanVal();
    var nome = document.getElementById('nome').value;
    var senha1 = document.getElementById('password1').value;
    var senha2 = document.getElementById('password2').value;
    var tel = document.getElementById('tel').value;
    var mail = document.getElementById('email').value;



    if (nome == "" || senha1 == "" || senha2 == "" || tel == "" || mail == "") {

        //caixa de diálogo
        app.dialog.alert("Preencha todos os campos antes de se cadastrar!", "Aviso:");


    } else {

        if (senha1 == senha2) {

            app.dialog.confirm("Deseja mesmo inserir o usuário " + nome + "?", "Pergunta", function () {
                inserecadastro();
            });

        } else {

            app.dialog.alert("As senhas digitadas não coincidem!", "Aviso:");
            document.getElementById('password1').value = "";
            document.getElementById('password2').value = "";

        }


    }



}

function inserecadastro() {
var telefoneverdadeiro = $('#tel').cleanVal();
    app.preloader.show('blue');
    
    $.post("php/inserecadastro.php", { tel: telefoneverdadeiro, password: document.getElementById("password1").value, nome: document.getElementById("nome").value, email: document.getElementById("email").value })
        .done(function( data ){
            
            console.log(data);
            if(data == " s"){
                
                app.dialog.alert("Usuário inserido!", "Aviso:");
                 localStorage.setItem("Telefone", telefoneverdadeiro);
                 localStorage.setItem("Nome", document.getElementById("nome").value);
                localStorage.setItem("TelefoneMask", document.getElementById("tel").value);
                localStorage.setItem("Senha", document.getElementById("password1").value);
                app.router.navigate('/ongs/');
                app.panel.enableSwipe();
                app.preloader.hide();
            }else{
                
              app.dialog.alert("Usuário não inserido!", "Erro:");    
                 app.preloader.hide();
               
            }
        });


}

function carreganecessidade2(ong) {

 var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selectnecessidades.php?ong="+ong+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            if(dados.length == i+1){
                
                conteudo += dados[i].tb03_tipo+".";
                
            }else{
            
            conteudo += dados[i].tb03_tipo+", ";
            
            }



        }
        
        document.getElementById("necessidades").innerHTML = "<b>Aceita:</b> "+conteudo;
        

    }
    
}

function carregaurgencia2(ong) {

 var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selecturgencias.php?ong="+ong+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        try{
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            if(dados.length == i+1){
                
                conteudo += dados[i].tb03_tipo+".";
                
            }else{
            
            conteudo += dados[i].tb03_tipo+", ";
            
            }



        }
        
        document.getElementById("urgencias").innerHTML = "<b>URGÊNCIAS:</b> "+conteudo;
        

    
        }catch{
        
        
}
    
}
    }


function carregaconturgencia(ong) {

 var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selecturgenciascont.php?ong="+ong+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            conteudo = dados[i].count;
            
        }
        
        if(conteudo == "1") 
        {
        document.getElementById("u"+ong).innerHTML = "ATENÇÃO: A ONG NECESSITA DE "+conteudo+" MATERIAL COM URGÊNCIA!";
        }else{
            
            if(conteudo == "0"){
                
            } else{
                
               document.getElementById("u"+ong).innerHTML = "ATENÇÃO: A ONG NECESSITA DE "+conteudo+" MATERIAIS COM URGÊNCIA!"; 
            }
            
            
        }
        
        
          
            
    }
    
    app.preloader.hide;
    
}

function sair() {

    app.panel.close();
    app.router.navigate('/index/');
    app.panel.disableSwipe();
    localStorage.clear();

}

function carreganecessidade(ong) {

 var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selectnecessidades.php?ong="+ong+"";




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {   
            if(dados.length == i+1){
                
                conteudo += dados[i].tb03_tipo+".";
                
            }else{
            
            conteudo += dados[i].tb03_tipo+", ";
            
            }



        }
        
        document.getElementById("td"+ong).innerHTML = "<b>Aceita:</b> "+conteudo;
        

    }
    
}

$$('.convert-form-to-data').on('click', function () {
    var formData = app.form.convertToData('#my-form');
    alert(JSON.stringify(formData));
});

$$('.fill-form-from-data').on('click', function () {
    var formData = {
        'name': 'John',
        'email': 'john@doe.com',
        'gender': 'female',
        'toggle': ['yes'],
    }
    app.form.fillFromData('#my-form', formData);
});

var allowInfinite = true;

var messagebar = app.messagebar.create({
    el: '.messagebar',
    attachments: []
});

$$(document).on('page:init', '.page[data-name="ongs"]', function (e) {
    
    app.preloader.show('blue');
    var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selectongs.php";
    document.getElementById('username').innerHTML = localStorage.getItem("Nome");




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {
            var numero = dados[i].tb01_telefone;
            var ddd = numero.substring(0, 2);
            var part1;
            var part2;
            
            if(numero.length == 11){
                
                
               part1 = numero.substring(2, 7);
               part2 = numero.substring(7, 11);
                
            }else{
                
                part1 = numero.substring(2, 6);
               part2 = numero.substring(6, 10);
            }
            
            
            
            
            conteudo += "<br> <br><div class='row' >";
            conteudo += "<div class='col-33'>";
            conteudo += "<div style='padding-left: 9px;'> <img src='imgs/"+dados[i].tb01_cnpj+".png' style='height: 70px'></div>";
            conteudo += " </div>";
            conteudo += "<div class='col-33'>";
            conteudo += "<button class='col button button-small button-round button-outline color-green' onclick='chat("+dados[i].tb01_cnpj+")' style='font-size: 10px;'>Conversar</button>";
            conteudo += "</div>";
            conteudo += "<div class='col-33'>";
            conteudo += "<button class='col button button-small button-round button-outline color-white' onclick='chamafot("+dados[i].tb01_cnpj+")' style='font-size: 10px'>Fotos</button>";
            conteudo += "</div>";
            conteudo += "</div>";
            conteudo += "<div class='card card-outline' onclick='carregainfo("+dados[i].tb01_cnpj+")'>";

            conteudo += "<div class='card-header'><b>"+dados[i].tb01_nome+"</b></div>";
            conteudo += "<div class='card-content card-content-padding'><b>Endereço:</b> "+dados[i].tb01_endereco+", "+dados[i].tb01_bairro+"<br>";
            conteudo += "<p id='td"+dados[i].tb01_cnpj+"'></p><p style='font-weight: bolder !important;' id='u"+dados[i].tb01_cnpj+"'></p></div>";
            conteudo += "<div class='card-footer'><b>Contato: ("+ddd+") "+part1+"-"+part2+"<br> Email: "+dados[i].tb01_email+"</div></b>";
            conteudo += "</div>";
            conteudo += "<br><br>";
           carreganecessidade(dados[i].tb01_cnpj);
            carregaconturgencia(dados[i].tb01_cnpj);



        }
        app.preloader.hide();
        document.getElementById("c1").innerHTML = conteudo;
        

    }
});
        
$$(document).on('page:init', '.page[data-name="campanha"]', function (e) {
    document.getElementById('c3').innerHTML = "e";
     app.preloader.show('blue');
    var interval = setInterval(function () {

            
        if(document.getElementById('c3').innerHTML == "e" ){
            
            clearInterval(interval);
            
             var xmlhttp = new XMLHttpRequest();
    var url = "http://localhost/www/php/selectongs.php";
    document.getElementById('username').innerHTML = localStorage.getItem("Nome");




    xmlhttp.onreadystatechange = function () {

        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            ConectaServidor(xmlhttp.responseText);
        }
    }

    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    function ConectaServidor(response) {
        var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
        var i;
        var conteudo = "";


        for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
        {
            var numero = dados[i].tb01_telefone;
            var ddd = numero.substring(0, 2);
            var part1;
            var part2;
            
            if(numero.length == 11){
                
                
               part1 = numero.substring(2, 7);
               part2 = numero.substring(7, 11);
                
            }else{
                
                part1 = numero.substring(2, 6);
               part2 = numero.substring(6, 10);
            }
            
            
            
            
            conteudo += "<br> <br><div class='row' >";
            conteudo += "<div class='col-33'>";
            conteudo += "<div style='padding-left: 9px;'> <img src='imgs/"+dados[i].tb01_cnpj+".png' style='height: 70px'></div>";
            conteudo += " </div>";
            conteudo += "<div class='col-33'>";
            conteudo += "<button class='col button button-small button-round button-outline color-green' onclick='chamachat("+dados[i].tb01_cnpj+")' style='font-size: 10px;'>Conversar</button>";
            conteudo += "</div>";
            conteudo += "<div class='col-33'>";
            conteudo += "<button class='col button button-small button-round button-outline color-white' onclick='chamafot("+dados[i].tb01_cnpj+", '"+dados[i].tb01_nome+"')' style='font-size: 10px'>Fotos</button>";
            conteudo += "</div>";
            conteudo += "</div>";
            conteudo += "<div class='card card-outline' onclick='carregainfo("+dados[i].tb01_cnpj+")'>";

            conteudo += "<div class='card-header'><b>"+dados[i].tb01_nome+"</b></div>";
            conteudo += "<div class='card-content card-content-padding'><b>Endereço:</b> "+dados[i].tb01_endereco+", "+dados[i].tb01_bairro+"<br>";
            conteudo += "<p id='td"+dados[i].tb01_cnpj+"'></p><p style='font-weight: bolder !important;' id='u"+dados[i].tb01_cnpj+"'></p></div>";
            conteudo += "<div class='card-footer'><b>Contato: ("+ddd+") "+part1+"-"+part2+"<br> Email: "+dados[i].tb01_email+"</div></b>";
            conteudo += "</div>";
            conteudo += "<br><br>";
           carreganecessidade(dados[i].tb01_cnpj);
            carregaconturgencia(dados[i].tb01_cnpj);



        }
        app.preloader.hide();
        document.getElementById("c3").innerHTML = conteudo;
        document.getElementById("left").innerHTML = "";
        
        

    }
            
            
            
        }else{
            
           
            clearInterval(interval);
        }

        }, 2000);
    app.preloader.hide();
    
});


