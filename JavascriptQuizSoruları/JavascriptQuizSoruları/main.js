
//öncelikle for döngüsü ile 1 den 10 kadar sıraladık daha sonra sıralarken if ile kontrollerimizi yaptık 2ye bölünüyorsa rengi kırmızı bölünmüyorsa yeşil 
function Arrange() {
    for (var i = 1; i < 10; i++) {
        if (i % 2 == 0) {
            
            document.write("<font color='red'>"+i+"</font>")
        }
        else {
            document.write("<font color='green'>"+i+"</font>")
        }
    }
}

function Fak() {
    
    var faktöriyel = 1;
    var sayi= document.getElementById("Fakt").value;
    sayi = Number(sayi);
    if (sayi>=0) {
        for (var i = 1; i <sayi+1; i++) {
            faktöriyel=faktöriyel*i
        }
        document.write(faktöriyel)
    }
}
function Multiple() {
    var toplam = 0;
    for (var i = 100; i < 200; i++) {
        if (i % 23 == 0) {
            toplam = toplam + i;           
        }      
    }
    document.write(toplam);
}
function Small() {
    var x = document.getElementById("x").value;
    var y = document.getElementById("y").value;
    var z = document.getElementById("z").value;
    if (x<y&&x<z) {
        
            document.write(x)
       
    }
    else if (y < x &&y<z) {
        
            document.write(y)
        
    }
    else if (z < x &&z<y) {
        document.write(z)
    }
}