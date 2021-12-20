<template>
<div class="all">
  <h1>Update car</h1>
  <form @submit.prevent = "UpdateCar" class="uk-form-stacked">
    <div class="input-field">
      <div class="uk-margin">
        <label for="Id" class="uk-form-label">Номер машини</label>
        <input type="text" id="Id" name="Id" placeholder="Numberplate" v-model="Car.Id" class="uk-input uk-width-medium uk-form-controls">
      </div>
      <div class="uk-margin">
        <label for="Model" class="uk-form-label">Модель машини</label>
        <input type="text" name="Model" placeholder="Model" v-model="Car.Model" class="uk-input uk-width-medium uk-form-controls">
      </div>
      <div class="uk-margin">
        <label for="Color" class="uk-form-label">Колір машини</label>
        <input type="text" name="Color" placeholder="Color" v-model="Car.Color" class="uk-input uk-width-medium uk-form-controls">
      </div>
      <div class="uk-margin">
        <label for="Type" class="uk-form-label">Тип машини</label>
        <input type="text" name="Type" placeholder="Type" v-model="Car.Type" class="uk-input uk-width-medium uk-form-controls">
      </div>
      <input type="submit" class="uk-button uk-button-default" value="Update">
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
    async UpdateCar() {
      await axios.put('carlist/' + this.Car.Id, this.Car).then(res => {
        console.log(res)
      })

      this.Car.Id = ''
      this.Car.Model = ''
      this.Car.Color = ''
      this.Car.Type = ''

      this.$emit('dataRefreshEvent')

    }
  }

}
</script>

<style scoped>

</style>