var app = new Vue({
    el: '#app',
    data: {
        price: 0,
        showPrice: true,
        loading: false,
        productModel: {
            name: "Product Name",
            description: "Product Description",
            value: 1.99
        },
        products: []
    },

    methods: {
        togglePrice: function () {
            this.showPrice = !this.showPrice;
        },
        alert(v) {
            alert(v);
        },
        getProducts() {
            this.loading = true;
            axios.get('/Admin/products')
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createProduct() {
            this.loading = true;
            axios.post('/Admin/products', this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        }
    },
    computed: {
        formatPrice: function () {
            return "£" + this.price;
        }
    }

});