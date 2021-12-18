<template>
    <div class="all post">
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
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script lang="js">
    import Vue from 'vue';

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
            async postData() {
              const res = await fetch('test', {
                method: 'POST',
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(a1)
              });
              console.log(res.json)
            },
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
                fetch('weatherforecast')
                    .then(r => r.json())
                    .then(json => {
                        this.post = json;
                        this.loading = false;
                        return;
                    });
            }
        },
    });
</script>