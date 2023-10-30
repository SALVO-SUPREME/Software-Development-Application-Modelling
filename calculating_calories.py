# calculating calories
# equation provided: per 3500 calories = 1 lb is lost

# calories lost from;
cycling_cals = 200
running_cals = 475
swimming_cals = 275

cycle_hours = float(input("How many hours spent cycling: "))
running_hours = float(input("How many hours spent running: "))
swimming_hours = float(input("How many hours spent swimming: "))

# the total amount of calories lost from each activity
cycle_total_cals = cycle_hours*cycling_cals
running_total_cals = running_hours*running_cals
swimming_total_cals = swimming_hours*swimming_cals

total_cals_burnt = cycle_total_cals + running_total_cals + swimming_total_cals

total_pounds_lost = total_cals_burnt / 3500

print("You have burnt {} calories and lost {} pounds. Well Done!".format(total_cals_burnt, total_pounds_lost))
