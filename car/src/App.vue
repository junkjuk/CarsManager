<template>
  <div id="app">
    <nav class="uk-navbar-container">
      <div class="uk-navbar-center uk-align-center">
        <ul class="uk-navbar-nav">
          <li class="uk-active">
            <router-link to="/">List</router-link>
          </li>
          <li class="uk-active">
            <router-link to="/add">Add</router-link>
          <li class="uk-active">
            <router-link to="/update">Update</router-link>
          </li>
          <li class="uk-active">
            <router-link to="/delete">Delete</router-link>
          </li>
        </ul>
      </div>
    </nav>

      <router-view @dataRefreshEvent="fetchData"></router-view>
    <div>
      <div v-if="loading" class="loading">
        Loading...
      </div>

      <div v-if="testData" class="content uk-width-large uk-align-center">
        <table class="uk-table uk-table-hover uk-table-divider">
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
            <td><button @click="DeleteCar(car.id)" class="uk-button uk-button-default">Delete</button></td>
          </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script>
import CarList from './components/CarList.vue'
import AddCar from "./components/AddCar";
import DeleteCar from "./components/DeleteCar";
import UpdateCar from "./components/UpdateCar";
import axios from "axios";

export default {
  name: 'App',
  data() {
    return {
      loading: false,
      post: null,
      testData: null
    };
  },
  created() {
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
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
