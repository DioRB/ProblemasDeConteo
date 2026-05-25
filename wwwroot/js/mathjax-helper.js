// Recibe todo lo necesario para mostrar las formulas
export async function renderMathJax(latexFormula) {

    if (!window.MathJax) return;

    await MathJax.startup.promise;

    const target = document.getElementById('math-output');
    const targetComp = document.getElementById('verificacion-igualdad');

    // El calculo binomial de a y b
    if (target) {

        MathJax.typesetClear([target]);

        target.innerHTML = `\\[ ${latexFormula} \\]`;
    }

    // La formula estática donde se verifica la igualdad 
    if (targetComp) {

        MathJax.typesetClear([targetComp]);

        targetComp.innerHTML =
            `\\[
            \\binom{a+b}{a} = \\binom{a+b}{b}
            \\]`;
    }

    await MathJax.typesetPromise([target, targetComp]);
}