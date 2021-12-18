<template>
<div class="all">
  <h1>asd</h1>
  <form @submit.prevent = "PostData11">
    <div class="input-field">

      <input type="text" name="Id" placeholder="Id" v-model="Car.Id"><br>
      <input type="text" name="Model" placeholder="Model" v-model="Car.Model"><br>
      <input type="text" name="Color" placeholder="Color" v-model="Car.Color"><br>
      <input type="text" name="Numberplate" placeholder="Numberplate" v-model="Car.Numberplate"><br>

      <input type="submit">
    </div>
  </form>

</div>
</template>

<script>
import axios from "axios";

export default {
  name: "AddCar",
  data() {
    return {
      employees: [],
      Car: {
        Id:'',
        Model:'',
        Color:'',
        Numberplate:''
      }
    };
  },
  methods: {
    PostData11(){
      axios.post('test',this.Car).then(res=>{
        console.log(res)
      })
    }
  }
}
</script>

<style scoped>

</style>