var app = new Vue({
    el: '#app',
    data: {
        price: 0,
        showPrice: true,
    },

    methods: {
        togglePrice: function () {
            this.showPrice = !this.showPrice;
        },
        alert(v) {
            alert(v);
        }
    },

    computed: {
        formatPrice: function () {
            return "£" + this.price;
        }
    }

});