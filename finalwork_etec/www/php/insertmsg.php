<?php

    /* 
        Veja o material da aula aqui: 
        http://profanderson.blog.etecarmine.com.br/conectando-o-php-ao-mysql-com-pdo/
    */
    header("Content-type: text/html; charset=utf-8");

    include('dados_conexao.php'); // inclui o arquivo com as variaveis para conectar ao banco.

    try { 
        
        // tenta fazer a conexão e executar o INSERT
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
		$query = "INSERT INTO tb02_albuns (tb05_status, tb05_de, tb05_data, tb05_para, tb05_mensagem)
VALUES ('1', '$_GET[tel]', 'now(), '$_GET[ong]', '$_GET[msg]')";
		
        $grava = $conecta->prepare($query);
		$grava->execute(array()); 
        
        /* 
            Para testar, acesse este arquivo via HTTP, passe os valores
            a serem gravados na URL via parâmentros (GET). 
            
            Por exemplo
            http://endereco-do-servidor/nome-deste-arquivo.php?parametro1=valor&parametro2=valor
            
            Descomente a linha abaixo (echo) e verifique se o registro foi gravado 
            corretamente no banco de dados.
		*/
        
         echo("<script> alert('gravado com sucesso!')</script>");
 
	} catch(PDOException $e) { // casso retorne erro
		echo('Deu erro: ' . $e->getMessage()); 
	}
?>