window.keyCapture = {
    registerKeyEvents: function (dotNetReference) {
        document.addEventListener('keydown', (event) => {
            if (event.target.tagName !== 'INPUT' && event.target.tagName !== 'TEXTAREA') {
                dotNetReference.invokeMethodAsync('OnKeyPress', event.key);
            }
        });
    }
};
