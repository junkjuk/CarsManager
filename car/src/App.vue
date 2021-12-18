<template>
  <div id="app">
    <AddCar></AddCar>
    <CarList msg="Welcome to Your Vue.js App"/>
  </div>
</template>

<script>
import CarList from './components/CarList.vue'
import AddCar from "./components/AddCar";

export default {
  name: 'App',
  components: {
    CarList,
    AddCar
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
