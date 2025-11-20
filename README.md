# 03_VersionamentoPalavras
 - Neste versionamento do jogo Palavras, AlphabetDataDrawer.cs foi atualizado porque ao ser iniciado está
 - manhã, continha " NullReferenceException " que aparecia no Console, porque
 - uma das suas 4 ReorderableLists (plainList, normalList, highlightedList ou wrongList) ainda estava null quando o OnInspectorGUI() rodava.
 - Isso aconteceu porque no OnEnable() eu estava chamando o CreateList() sem passar por referência (ou com a assinatura errada),
 - então o valor que eu criava dentro do método não voltava para o campo da classe.
 - <img src="2025-11-20.png" width="500px">


# CÓDIGO FONTE:
- 1 https://www.youtube.com/watch?v=AAGuuSVBk8M&list=PLJLLSehgFnspMBk7VaLI18Digsj2xuMhT&index=1

#
- 2 https://www.youtube.com/watch?v=M0viZrgunNI&list=PLJLLSehgFnspMBk7VaLI18Digsj2xuMhT&index=2

#
- 3 https://www.youtube.com/watch?v=NwtiYSVplHA&list=PLJLLSehgFnspMBk7VaLI18Digsj2xuMhT&index=3

#
- 4 https://www.youtube.com/watch?v=5XCDkd61-i8&list=PLJLLSehgFnspMBk7VaLI18Digsj2xuMhT&index=4

#
- 5 https://www.youtube.com/watch?v=aDTtgv3RgCQ&list=PLJLLSehgFnspMBk7VaLI18Digsj2xuMhT&index=5

#
- 6 https://www.youtube.com/watch?v=r4MFdbkIM0M&list=PLJLLSehgFnspMBk7VaLI18Digsj2xuMhT&index=10


# Meus Games:
- https://trechosgame.github.io/Jogo_Da_Forca/app.html
- https://trechosgame.github.io/Jogo-Quem-Sou-Eu/app.html
- https://trechosgame.github.io/Quiz-Responsivo/quiz.html

# Redes Sociais:
- https://www.instagram.com/trechosgame/
- https://www.behance.net/trechosgame
- https://www.colab55.com/@trechosdecodigo
- https://www.youtube.com/channel/UCfEsOEx_t6hiIms8HzttxOw/featured
- https://github.com/trechosgame  

# Color Palette:
 - https://mycolor.space

# Editor de Códigos Online:
- https://www.programiz.com/

# Editor de Imagens Online:
 - https://www.resizepixel.com/pt/edit

# Imagens:
- https://www.freepik.com/
- https://www.storyset.com/
- https://www.undraw.com/
- https://www.pixabay.com/
- https://www.unsplash.com/
- https://www.flaticon.com/
- https://www.pngegg.com/


