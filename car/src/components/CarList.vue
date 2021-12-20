<template>
    <div class="all">
        <div v-if="loading" class="loading">
            Loading...
        </div>

        <div v-if="testData" class="content">
            <table>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Color</th>
                        <th>Model</th>
                        <th>Numberplate</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="car in testData">
                        <td>{{ car.id}}</td>
                        <td>{{ car.color }}</td>
                        <td>{{ car.model }}</td>
                        <td>{{ car.type }}</td>
                        <td><button @click="DeleteCar(car.id)">Delete</button></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script lang="js">
    import Vue from 'vue';
    import axios from "axios";

    export default Vue.extend({
        data() {
            return {
                loading: false,
                post: null,
                testData: null
            };
        },
        created() {
            console.log("ASD")
            this.fetchData();

        },
        watch: {
            '$route': 'fetchData'
        },
        methods: {

            fetchData() {
                this.post = null;
                this.loading = true;
                this.testData = null;
                fetch('carlist')
                    .then(r => r.json())
                    .then(json => {

                        this.testData = json;
                        this.loading = false;
                        console.log(json);
                        return;
                    });
            },
            async DeleteCar(Id) {
              await axios.delete('carlist/' + Id).then(res => {
                console.log(res);
              })
              this.fetchData();
            }
        },
    });
</script>