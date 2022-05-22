const rolarD6 = function(vezesRoladas){
    let arrayDeRolls=[];
    let acerto = 0;
    let falha = 0;
    for(let i = 0; i < vezesRoladas; i++){
        let dSixRoll = (Math.ceil(Math.random()*6));
        if (dSixRoll == 1){
            acerto -=1
            
        }else if(dSixRoll <= 3){
            falha++
        }else if(dSixRoll <= 5){
            acerto++
        }else{
            acerto += 2
        }
        arrayDeRolls[i] = dSixRoll;
    }
    return `Acertos: ${acerto} - Falhas: ${falha} - NumerosRolados: ${arrayDeRolls}`
}

console.log(rolarD6(2))