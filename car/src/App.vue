<template>
  <div id="app">
    <router-link to="/list">List</router-link>
    <router-link to="/add">Add</router-link>
    <router-link to="/update">Update</router-link>
    <router-link to="/delete">Delete</router-link>

      <router-view></router-view>

<!--    <AddCar></AddCar>-->
<!--    <DeleteCar></DeleteCar>-->
<!--    <UpdateCar></UpdateCar>-->
    <CarList></CarList>
  </div>
</template>

<script>
import CarList from './components/CarList.vue'
import AddCar from "./components/AddCar";
import DeleteCar from "./components/DeleteCar";
import UpdateCar from "./components/UpdateCar";

export default {
  name: 'App',
  components: {
    CarList,
    AddCar,
    DeleteCar,
    UpdateCar
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
