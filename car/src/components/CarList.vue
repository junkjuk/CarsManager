<template>
    <div class="all">
        <div v-if="loading" class="loading">
            Loading...
        </div>

        <div v-if="post" class="content">
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
                        <td>{{ car.numberplate }}</td>
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

    const a1 = {
      name:'qwe',
      age:'12'
    }
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
                fetch('test')
                    .then(r => r.json())
                    .then(json => {
                        this.testData = json;
                        this.loading = false;
                        console.log(json);
                        return;
                    });
            },
            DeleteCar(){
                axios.delete('test/'+this.CarId).then(res => {
                    console.log(res)
                })
            }
        }
    });
</script>