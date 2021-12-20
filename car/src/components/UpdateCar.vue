<template>
<div class="all">
  <form @submit.prevent = "UpdateCar">
    <h1>Update car</h1>
    <div class="input-field">
      <input type="text" name="Id" placeholder="Id" v-model="Car.Id"><br>
      <input type="text" name="Model" placeholder="Model" v-model="Car.Model"><br>
      <input type="text" name="Color" placeholder="Color" v-model="Car.Color"><br>
      <input type="text" name="Type" placeholder="Type" v-model="Car.Type"><br>

      <input type="submit">
    </div>
  </form>
</div>
</template>

<script>
import axios from "axios";

export default {
  name: "UpdateCar",
  data() {
    return {
      Car: {
        Id:'',
        Model:'',
        Color:'',
        Type:''
      }
    };
  },
  methods: {
    UpdateCar(){
      axios.put('carlist/'+this.Car.Id, this.Car).then(res => {
        console.log(res)
      })
    }
  }

}
</script>

<style scoped>

</style>