const cidades = {
    SP : 67836.43,
    RJ : 36678.66,
    MG : 29229.88,
    ES : 27165.48,
    Outros : 19849.53
}
const total = cidades.ES + cidades.MG + cidades.Outros + cidades.RJ + cidades.SP;

function percentualCidades(cidade){
    return cidade * 100 / total
}

console.log(percentualCidades(cidades.ES))
console.log(percentualCidades(cidades.Outros))
console.log(percentualCidades(cidades.MG))
console.log(percentualCidades(cidades.RJ))
console.log(percentualCidades(cidades.SP))