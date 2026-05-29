// Obtiene los id para hacer el renderizado en latex
export async function renderMath(elementId, latexContent) {
    if (!window.MathJax) return;

    await MathJax.startup.promise;

    const target = document.getElementById(elementId);
    if (!target) return;

    MathJax.typesetClear([target]);

    target.innerHTML = `\\[
        ${latexContent}
    \\]`;

    await MathJax.typesetPromise([target]);
}